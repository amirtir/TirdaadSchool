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
        void AddRolesToUser(List<int> roleIds,int userid);
        void EditRolesToUser(List<int> roleIds, int userid);
    }
}
