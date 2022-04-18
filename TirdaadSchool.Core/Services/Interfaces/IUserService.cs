using System;
using System.Collections.Generic;
using System.Text;
using TirdaadSchool.DataLayer.Entities.User;
using TirdaadSchool.Core.DTOs;

namespace TirdaadSchool.Core.Services.Interfaces
{
  public  interface IUserService
    {
        bool IsUserNameExist( string username);
        bool IsEmailExist( string email);
        int AddUser(User user);
        bool ActiveAcount(string activecode);
        int UpdateUser(User user);
        User LoginUser(LoginviewModel loginViewModel);
        User GetUserByEmail( string email);
        User GetUserByUserName(string username);
        bool ResetPassword(ResetPasswordViewModel resetPasswordViewModel);



        #region UserPanel

        InformationUserViewModel GetUserInformation(string username);
        InformationSidebarViewModel SideBarInformation(string username);
        EditProfileViewModel GetDataForEditProfileUser(string username);
        void UpdateProfile(EditProfileViewModel model);
        #endregion
    }
}
