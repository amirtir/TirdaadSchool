using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TirdaadSchool.DataLayer.Entities.User;

namespace TirdaadSchool.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        List<Role> GetRoles();
        int AddRole(Role role);
        int UpdateRole(Role role);
        void DeleteRole(Role role);
        Role GetRoleById(int id);
        void AddRolesToUser(List<int> roleIds,int userid);
        void EditRolesToUser(List<int> roleIds, int userid);
    }
}
