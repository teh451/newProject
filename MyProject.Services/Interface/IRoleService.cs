using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interface
{
    public interface IRoleService
    {
        List<RoleDTO> GetAll();

        RoleDTO GetById(int id);

        RoleDTO Add(int id, string name, string description);

        RoleDTO Update(RoleDTO permission);

        void Delete(int id);
    }
}
