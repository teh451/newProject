using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interface
{
    public interface IPermissionService
    {

        List<PermissionDTO> GetAll();

        PermissionDTO GetById(int id);

        PermissionDTO Add(int id, string name, string description);

        PermissionDTO Update(PermissionDTO permission);

        void Delete(int id);
    }
}
