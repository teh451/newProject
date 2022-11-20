using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interface
{
    public interface IClaimService
    {
        List<ClaimDTO> GetAll();

        ClaimDTO GetById(int id);

        ClaimDTO Add(int id,  PermissionDTO permission, RoleDTO role, ePolicy policy);

        ClaimDTO Update(ClaimDTO claim);

        void Delete(int id);
    }
}
