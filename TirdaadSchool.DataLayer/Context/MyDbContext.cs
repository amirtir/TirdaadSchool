using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TirdaadSchool.DataLayer.Entities.User;
using TirdaadSchool.DataLayer.Entities.Wallet;

namespace TirdaadSchool.DataLayer.Context
{
  public  class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        #region Users

        public DbSet<User> Users   { get; set; }
        public DbSet<Role> Roles  { get; set; }
        public DbSet<UserRole> UserRoles  { get; set; }



        #endregion

        #region Wallet

        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        #endregion
      
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<User>().HasQueryFilter(u => !u.IsDeleted);
            model.Entity<Role>().HasQueryFilter(r => !r.IsDeleted);
            base.OnModelCreating(model);
        }
    }
}
