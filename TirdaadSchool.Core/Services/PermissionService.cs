using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Context;
using TirdaadSchool.DataLayer.Entities.Permissions;
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

        public void AddPermissionsToRole(int roleid, List<int> permissions)
        {
         foreach (var item in permissions)
            {
                _db.rolePermissions.Add(new RolePermission { RoleId = roleid, PermissionId = item });
            }
            _db.SaveChanges();
        }
        public List<int> SelectedPermissions(int id)
        {
            return _db.rolePermissions.Where(r=> r.RoleId==id).Select(r=>r.PermissionId).ToList();
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

        public List<Permission> GetAllPermissions()
        {
            return _db.Permissions.ToList();
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

        public void UpdatePermissionsRoles(int roleid, List<int> permissions)
        {
            _db.rolePermissions.Where(p => p.RoleId == roleid).ToList()
                .ForEach(p => _db.rolePermissions.Remove(p));
            AddPermissionsToRole(roleid,permissions);
        }

        public bool CheckPermission(int permissiomid, string username)
        {
            var user = _db.Users.SingleOrDefault(u => u.UserName == username);
            var userid = user.UserId;

            List<int> userroles = _db.UserRoles.Where(ur => ur.UserId == userid).Select(ur => ur.RoleId).ToList();
            if (!username.Any())
            {
                return false;
            }

            List<int> rolePermissions = _db.rolePermissions.Where(r => r.PermissionId == permissiomid).Select(r=>r.RoleId).ToList();
            return rolePermissions.Any(rp => userroles.Contains(rp));
        }
    }
}
