using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class RepositoryPermission : IRepositoryPermission
    {
        private readonly IContex _contex;
        public RepositoryPermission(IContex con)
        {
            _contex = con;
        }
        public Permission Add(int id, string name, string desc)
        {
            var nPer=new Permission { Id = id ,Name=name,Descripsion=desc};
            _contex.Permissions.Add(nPer);
            return nPer;
        }

        public void Delet(int id)
        {
            for (int i = 0; i < _contex.Permissions.Count; i++)
            {
                if (_contex.Permissions[i].Id == id)
                {
                    _contex.Permissions.RemoveAt(i);
                }
            }
        }

        public List<Permission> GetAll()
        {
            return _contex.Permissions;
        }

        public Permission GetById(int id)
        {
            for (int i = 0; i < _contex.Permissions.Count; i++)
            {
                if (_contex.Permissions[i].Id==id)
                {
                    return _contex.Permissions[i];
                }
            }
            return null;
        }

        public Permission Update(Permission obj)
        {
            for (int i = 0; i < _contex.Permissions.Count; i++)
            {
                if (_contex.Permissions[i].Id==obj.Id)
                {
                    _contex.Permissions[i].Name = obj.Name;
                    _contex.Permissions[i].Descripsion= obj.Descripsion;
                    return _contex.Permissions[i];
                }
            }
            return null;
        }
    }
}
