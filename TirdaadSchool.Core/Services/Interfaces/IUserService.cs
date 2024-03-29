﻿using System;
using System.Collections.Generic;
using System.Text;
using TirdaadSchool.DataLayer.Entities.User;
using TirdaadSchool.Core.DTOs;
using TirdaadSchool.Core.DTOs.WalletDTOs;
using TirdaadSchool.DataLayer.Entities.Wallet;
using TirdaadSchool.Core.DTOs.AdminPanelDTOs;

namespace TirdaadSchool.Core.Services.Interfaces
{
  public  interface IUserService
    {
        IEnumerable<User> getAllUsers();
        bool IsUserNameExist( string username);
        bool IsEmailExist( string email);
        int AddUser(User user);
        bool ActiveAcount(string activecode);
        int UpdateUser(User user);
        User LoginUser(LoginviewModel loginViewModel);
        User GetUserByEmail( string email);
        User GetUserByUserId(int userid);    
        User GetUserByUserName(string username);
        bool ResetPassword(ResetPasswordViewModel resetPasswordViewModel);
        void DeleteUser(int userid);


        #region UserPanel

        InformationUserViewModel GetUserInformation(string username);
        InformationUserViewModel GetUserInformation(int userid);
        InformationSidebarViewModel SideBarInformation(string username);
        EditProfileViewModel GetDataForEditProfileUser(string username);
        void UpdateProfile(EditProfileViewModel model);
        bool ChangePassword(string username,ChangePasswordViewModel changePasswordViewModel);
        #endregion

        #region Wallet

        int UserBalance(string username);
        List<WalletViewModel> GetWalletUser(string username);
        int ChargeWallet (string username, int amount, string Description, bool IsPay=false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int id);
        void UpdateWallet(Wallet wallet);
        #endregion


        #region AdminPanel

        FilterUsersViewModel GetFilterUsers(int pageid=1, string filterEmail="", string FilterUserName="" );
        FilterUsersViewModel GetDeletedFilterUsers(int pageid = 1, string filterEmail = "", string FilterUserName = "");
        public int AddUserByAdmin(NewUserViewModel newUser);
        public EditUserViewModel GetUserForEditMode(int userid);
        public  int EditUserByAdmin(EditUserViewModel editUser);

        #endregion
    }
}
