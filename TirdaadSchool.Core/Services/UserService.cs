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
using System.Runtime.CompilerServices;
using TirdaadSchool.Core.Senders;
using TirdaadSchool.Core.DTOs.WalletDTOs;
using TirdaadSchool.DataLayer.Entities.Wallet;
using TirdaadSchool.Core.DTOs.AdminPanelDTOs;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<User> getAllUsers()
        {
            return _DbContext.Users;
        }

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

            return _DbContext.Users.Include(u=>u.UserRoles)
                .ThenInclude(r=>r.role)
                .SingleOrDefault(u => u.Email == fixedEmail && u.Password == passwordHash);
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



        #region UserPanel

        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);

            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = UserBalance(username);
            return information;
        }
        public InformationUserViewModel GetUserInformation(int userid)
        {
            var user = GetUserByUserId(userid);

            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = UserBalance(user.UserName);
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
                UserId = u.UserId,
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
                    var imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar",
                        model.AvatarName);
                    if (File.Exists(imagepath))
                    {
                        File.Delete(imagepath);
                    }
                }

                model.AvatarName = GenerateTools.GenerateCode() + Path.GetExtension(model.AvatarFile.FileName);
                var imgpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", model.AvatarName);
                using (var stream = new FileStream(imgpath, FileMode.Create))
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
                user.UserName = model.UserName;

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

        public bool ChangePassword(string username, ChangePasswordViewModel changePasswordViewModel)
        {
            var user = _DbContext.Users.Single(u => u.UserName == username);

            var oldpassword = PasswordHelper.EncodePasswordMd5(changePasswordViewModel.OldPassword);
            if (user.Password == oldpassword)
            {
                user.Password = PasswordHelper.EncodePasswordMd5(changePasswordViewModel.Password);
                UpdateUser(user);
                return true;
            }

            return false;


        }

        #endregion



        #region Wallet

        public int UserBalance(string username)
        {
            var user = GetUserByUserName(username);
            var Deposit = _DbContext.Wallets.Where(w => w.UserId == user.UserId && w.TypeId == 1 && w.IsPay == true)
                .Select(w => w.Amount).ToList();
            var Withdraw = _DbContext.Wallets.Where(w => w.UserId == user.UserId && w.TypeId == 2 && w.IsPay == true)
                .Select(w => w.Amount).ToList();
            var balance = (Deposit.Sum() - Withdraw.Sum());
            return balance;
        }

        public List<WalletViewModel> GetWalletUser(string username)
        {
            var user = GetUserByUserName(username);
            return _DbContext.Wallets.Where(w => w.UserId == user.UserId && w.IsPay == true)
                .Select(w => new WalletViewModel()
                {
                    Amount = w.Amount,
                    Type = w.TypeId,
                    Description = w.Description,
                    DateTime = w.CreateDate
                })
                .ToList();


        }

        public int ChargeWallet(string username, int amount, string Description, bool IsPay = false)
        {
            var user = GetUserByUserName(username);
            Wallet wallet = new Wallet()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Description = Description,
                IsPay = IsPay,
                TypeId = 1,
                UserId = user.UserId
            };
            return AddWallet(wallet);
        }

        public int AddWallet(Wallet wallet)
        {
            _DbContext.Wallets.Add(wallet);
            _DbContext.SaveChanges();
            return wallet.WalletId;
        }

        public Wallet GetWalletByWalletId(int id)
        {
            return _DbContext.Wallets.Find(id);
        }

        public void UpdateWallet(Wallet wallet)
        {
            _DbContext.Wallets.Update(wallet);
            _DbContext.SaveChanges();
        }



        #endregion


        #region AdminPanel

        public FilterUsersViewModel GetFilterUsers(int pageid = 1, string FilterEmail = "", string FilterUserName = "")
        {
            IQueryable<User> result = _DbContext.Users;

            if (!string.IsNullOrEmpty(FilterEmail))
            {
                result = result.Where(x => x.Email.Contains(FilterEmail));
            }

            if (!string.IsNullOrEmpty(FilterUserName))
            {
                result = result.Where(x => x.UserName.Contains(FilterUserName));
            }

            //Show
            int take = 10;
            int skip = (pageid - 1) * take;

            FilterUsersViewModel res = new FilterUsersViewModel();
            res.users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            res.CurrentPage = pageid;
            res.PageCount = result.Count() / take;

            return res;
        }

        public int AddUserByAdmin(NewUserViewModel newUser)
        {
            User user = new User();
            user.Email = newUser.Email;
            user.UserName = newUser.UserName;
            user.Password = PasswordHelper.EncodePasswordMd5(newUser.Password);
            if (newUser.AvatarFile != null)
            {
                user.UserAvatar = GenerateTools.GenerateCode() + Path.GetExtension(newUser.AvatarFile.FileName);
                var imgpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
                using (var stream = new FileStream(imgpath, FileMode.Create))
                {
                    newUser.AvatarFile.CopyTo(stream);


                }
            }
            else
            {
                user.UserAvatar = "/UserAvatar/Default.jpg";
            }

            user.ActiveCode = GenerateTools.GenerateCode();
            user.RegisterDate = DateTime.Now;
            user.IsActive = true;

            return AddUser(user);

        }

        public EditUserViewModel GetUserForEditMode(int userid)
        {
            return _DbContext.Users.Where(u => u.UserId == userid).Select(u => new EditUserViewModel()
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    Email = u.Email,
                    AvatarName = u.UserAvatar,
                    //Password = u.Password,
                    UserRoles = u.UserRoles.Select(r => r.RoleId).ToList()
                }
            ).Single();

        }

        public int EditUserByAdmin(EditUserViewModel editUser)
        {
            User user = GetUserByUserId(editUser.UserId);
            user.Email = editUser.Email;
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }

            if (editUser.AvatarFile != null)
            {
                if (editUser.AvatarName != "Default.jpg")
                {
                    //Delete Old Image
                    string deletpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar",
                        editUser.AvatarName);
                    if (File.Exists(deletpath))
                    {
                        File.Delete(deletpath);
                    }
                }

                //Save New Image
                user.UserAvatar = GenerateTools.GenerateCode() + Path.GetExtension(editUser.AvatarFile.FileName);
                var imgpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
                using (var stream = new FileStream(imgpath, FileMode.Create))
                {
                    editUser.AvatarFile.CopyTo(stream);

                }

                _DbContext.Update(user);
                _DbContext.SaveChanges();
            }

            return user.UserId;

            #endregion
        }

        public FilterUsersViewModel GetDeletedFilterUsers(int pageid = 1, string filterEmail = "", string FilterUserName = "")
        {
            IQueryable<User> result = _DbContext.Users.IgnoreQueryFilters().Where(u=>u.IsDeleted==true);

            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(x => x.Email.Contains(filterEmail));
            }

            if (!string.IsNullOrEmpty(FilterUserName))
            {
                result = result.Where(x => x.UserName.Contains(FilterUserName));
            }

            //Show
            int take = 10;
            int skip = (pageid - 1) * take;

            FilterUsersViewModel res = new FilterUsersViewModel();
            res.users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            res.CurrentPage = pageid;
            res.PageCount = result.Count() / take;

            return res;
        }

        public void DeleteUser(int userid)
        {
            User user = GetUserByUserId(userid);
            user.IsDeleted = true;
            UpdateUser(user);
        }

        
    }
}
