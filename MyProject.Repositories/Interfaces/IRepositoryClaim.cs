using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Claim = MyProject.Repositories.Entities.Claim;

namespace MyProject.Repositories.Interfaces
{
    public interface IRepositoryClaim
    {
        public List<Claim> GetAll();
        public Claim GetById(int id);
        public Claim Add(int id,Permission idPer ,Role idRole, ePolicy Policy);
        public Claim Update(Claim obj);
        public void Delet(int id);
    }
}
