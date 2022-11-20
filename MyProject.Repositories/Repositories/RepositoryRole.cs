using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class RepositoryRole : IRepositoryRole
    {
        private readonly IContex _contex;
        public RepositoryRole(IContex c)
        {
            _contex = c;
        }
        public Role Add(int id, string name, string desc)
        {
            var nRole=new Role { Id = id, Name = name,Descripsion = desc };  
            _contex.Roles.Add(nRole);
            return nRole;
        }

        public void Delet(int id)
        {
            for (int i = 0; i < _contex.Roles.Count; i++)
            {
                if (_contex.Roles[i].Id==id)
                {
                    _contex.Roles.RemoveAt(i);         
                }
            }
        }

        public List<Role> GetAll()
        {
            return _contex.Roles;
        }

        public Role GetById(int id)
        {
            for (int i = 0; i < _contex.Roles.Count; i++)
            {
                if (_contex.Roles[i].Id==id)
                {
                    return _contex.Roles[i];
                }
            }
            return null;
        }

        public Role Update(Role role)
        {
            for (int i = 0; i < _contex.Roles.Count; i++)
            {
                if (_contex.Roles[i].Id==role.Id)
                {
                    _contex.Roles[i].Id = role.Id;
                    _contex.Roles[i].Name = role.Name;
                    _contex.Roles[i].Descripsion = role.Descripsion;
                    return _contex.Roles[i];    
                }
            }
            return null;
        }
    }
}
