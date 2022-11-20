using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum ePolicy
    {
        allow, deny
    }
    public class ClaimDTO
    {
        public int Id { get; set; }
        public RoleDTO RoleDto { get; set; }
        public PermissionDTO PermissionDto { get; set; }
        public ePolicy Policy { get; set; }
    }
}
