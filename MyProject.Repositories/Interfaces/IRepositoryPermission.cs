using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IRepositoryPermission
    {
        public List<Permission> GetAll();
        public Permission GetById(int id);
        public Permission Add(int id, string name, string desc);
        public Permission Update(Permission obj);
        public void Delet(int id);
    }
}
