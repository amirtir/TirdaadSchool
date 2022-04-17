using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TirdaadSchool.DataLayer.Entities.User;

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



    }
}
