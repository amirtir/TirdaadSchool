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

        public int AddRole(Role role)
        {
         _db.Roles.Add(role);
            _db.SaveChanges();
            return role.RoleId;
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

        public void DeleteRole(Role role)
        {
  
            role.IsDeleted=true;
            UpdateRole(role);
        }

        public void EditRolesToUser(List<int> roleIds, int userid)
        {
          _db.UserRoles.Where(r => r.UserId == userid).ToList().ForEach(r => _db.UserRoles.Remove(r));

            AddRolesToUser(roleIds,userid);
        }

        public Role GetRoleById(int id)
        {
          return  _db.Roles.Find(id);
        }

        public List<Role> GetRoles()
        {
           return _db.Roles.ToList();
        }

        public int UpdateRole(Role role)
        {
           _db.Update(role);
            _db.SaveChanges();
            return role.RoleId;
        }
    }
}
