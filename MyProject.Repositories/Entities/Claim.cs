using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum ePolicy {Allow , Deny};
    public class Claim
    {
        public int Id { get; set; }
        public Role IdRole { get; set; }
        public Permission IdPermission { get; set; }
        public ePolicy Policy { get; set; }
    }
}
