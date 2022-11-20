using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IRepositoryRole
    {
        public List<Role> GetAll();
        public Role GetById(int id);
        public Role Add(int id, string name, string desc);
        public Role Update(Role obj);
        public void Delet(int id);
    }
}
