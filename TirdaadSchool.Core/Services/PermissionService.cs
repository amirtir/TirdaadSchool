using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Context;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private MyDbContext _db;

        public PermissionService( MyDbContext db)
        {
            _db=db;
        }

        public void AddRolesToUser(List<int> roleIds, int userid)
        {
            foreach (var item in roleIds)
            {
                _db.UserRoles.Add(new UserRole()
                {
                    RoleId = item,
                    UserId = userid
                });
                _db.SaveChanges();
            }
        }

        public void EditRolesToUser(List<int> roleIds, int userid)
        {
          _db.UserRoles.Where(r => r.UserId == userid).ToList().ForEach(r => _db.UserRoles.Remove(r));

            AddRolesToUser(roleIds,userid);
        }

        public List<Role> GetRoles()
        {
           return _db.Roles.ToList();
        }
    }
}
