using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Context;
using TirdaadSchool.DataLayer.Entities.User;
using TirdaadSchool.Core.Security;
using TirdaadSchool.Core.Convertor;
using TirdaadSchool.Core.DTOs;
using TirdaadSchool.Core.Generator;
using System.IO;
using TirdaadSchool.Core.Senders;

namespace TirdaadSchool.Core.Services
{
    public class UserService : IUserService
    {


        private MyDbContext _DbContext;
        private IViewRenderService _viewrender;

        public UserService(MyDbContext DbContext, IViewRenderService viewRender)
        {
            _DbContext = DbContext;
            _viewrender = viewRender;
        }

        #region Acount
        public bool IsUserNameExist(string username)
        {
            return _DbContext.Users.Any(u => u.UserName == username);
        }

        public bool IsEmailExist(string email)
        {
            return _DbContext.Users.Any(u => u.Email == email);
        }

        public int AddUser(User user)
        {
            _DbContext.Add(user);
            _DbContext.SaveChanges();
            return user.UserId;
        }

        public User GetUserByActiveCode(string activecode)
        {
            return _DbContext.Users.FirstOrDefault(u => u.ActiveCode == activecode);


        }

        public int UpdateUser(User user)
        {
            _DbContext.Users.Update(user);
            _DbContext.SaveChanges();
            return user.UserId;
        }

        public User LoginUser(LoginviewModel loginViewModel)
        {
            string fixedEmail = FixedText.FixedEmail(loginViewModel.Email);
            string passwordHash = PasswordHelper.EncodePasswordMd5(loginViewModel.Password);

            return _DbContext.Users.SingleOrDefault(u => u.Email == fixedEmail && u.Password == passwordHash);
        }

        public bool ActiveAcount(string activecode)
        {
            var user = _DbContext.Users.SingleOrDefault(u => u.ActiveCode == activecode);

            if (user == null || user.IsActive == true)
            {

                return false;
            }

            user.IsActive = true;
            user.ActiveCode = GenerateTools.GenerateCode();
            _DbContext.SaveChanges();
            return true;

        }

        public User GetUserByEmail(string email)
        {
            return _DbContext.Users.SingleOrDefault(u => u.Email == email);
        }

        public bool ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var user = _DbContext.Users.SingleOrDefault(u => u.ActiveCode == resetPasswordViewModel.ActiveCode);

            if (user == null)
            {
                return false;

            }

            var pass = PasswordHelper.EncodePasswordMd5(resetPasswordViewModel.Password);

            user.Password = pass;
            _DbContext.SaveChanges();
            return true;

        }

        public User GetUserByUserName(string username)
        {
            return _DbContext.Users.SingleOrDefault(u => u.UserName == username);
        }
        public User GetUserByUserId(int userid)
        {
            return _DbContext.Users.SingleOrDefault(u => u.UserId == userid);
        }
        #endregion



        #region  UserPanel
        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);

            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = 0;
            return information;
        }

        public InformationSidebarViewModel SideBarInformation(string username)
        {
            return _DbContext.Users.Where(u => u.UserName == username).Select(u => new InformationSidebarViewModel()
            {
                UserName = u.UserName,
                RegisterDate = u.RegisterDate,
                ImageName = u.UserAvatar
            }).Single();
        }

        public EditProfileViewModel GetDataForEditProfileUser(string username)
        {
            return _DbContext.Users.Where(u => u.UserName == username).Select(u => new EditProfileViewModel()
            {
                UserId=u.UserId,
                UserName = u.UserName,
                Email = u.Email,
                AvatarName = u.UserAvatar
            }).Single();
        }

        public void UpdateProfile(EditProfileViewModel model)
        {
            if (model.AvatarFile != null)


            {
                if (model.AvatarName != "Default.jpg")
                {
                    var imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", model.AvatarName);
                    if (File.Exists(imagepath))
                    {
                        File.Delete(imagepath);
                    }
                }

                model.AvatarName = GenerateTools.GenerateCode() + Path.GetExtension(model.AvatarFile.FileName);
              var imgpath=  Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/UserAvatar",model.AvatarName);
                using (var stream= new FileStream(imgpath, FileMode.Create))
                {
                    model.AvatarFile.CopyTo(stream);


                }

                var user = GetUserByUserId(model.UserId);
                user.UserName = model.UserName;

                if (user.Email != model.Email)
                {

                    string body = _viewrender.RenderToStringAsync("_ChangeEmail", user);

                    SendEmail.Send(user.Email, "فعالسازی حساب کاربری", body);
                }

                user.Email = model.Email;
                user.UserAvatar = model.AvatarName;
                UpdateUser(user);

            }

            else
            {
                var user = GetUserByUserId(model.UserId);
                user.UserName  = model.UserName;

                if (user.Email != model.Email)
                {
                    user.IsActive = false;
                    string body = _viewrender.RenderToStringAsync("_ChangeEmail", user);

                    SendEmail.Send(model.Email, "فعالسازی حساب کاربری", body);
                }

                user.Email = FixedText.FixedEmail(model.Email);
               
                UpdateUser(user);
            }

         

        }

        public bool ChangePassword(string username,ChangePasswordViewModel changePasswordViewModel)
        {
          var user=  _DbContext.Users.Single(u => u.UserName == username);

            var oldpassword = PasswordHelper.EncodePasswordMd5(changePasswordViewModel.OldPassword);
            if(user.Password== oldpassword)
            {
                user.Password = PasswordHelper.EncodePasswordMd5(changePasswordViewModel.Password);
                UpdateUser(user);
                return true;
            }

            return false;
    
           
        }



        #endregion


    }
}
