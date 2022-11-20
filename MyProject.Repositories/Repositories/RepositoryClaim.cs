using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repositories.Entities;
using Claim = MyProject.Repositories.Entities.Claim;
//using Claim = System.Security.Claims.Claim;

// למה מוסף לי לפני MyProject.Repositories.Entities.Claim
// במקום שיהיה כתוב רק Claim?????????????????????
namespace MyProject.Repositories.Repositories
{
    public class RepositoryClaim : IRepositoryClaim
    {
        private readonly IContex _contex;
        public RepositoryClaim(IContex con)
        {
            _contex = con;
        }
        public Claim Add(int id, Permission idPer, Role idRole, ePolicy policy)
        {
            var ncl = new Claim { Id = id, IdPermission = idPer, IdRole = idRole, Policy = policy };
            _contex.Claims.Add(ncl);
            return ncl;
        }

        public void Delet(int id)
        {
            for (int i = 0; i < _contex.Claims.Count; i++)
            {
                if (_contex.Claims[i].Id == id)
                {
                    _contex.Claims.RemoveAt(i);
                }
            }
        }

        public List<Claim> GetAll()
        {
            return _contex.Claims;
        }

        public Claim GetById(int id)
        {
            for (int i = 0; i < _contex.Claims.Count; i++)
            {
                if (_contex.Claims[i].Id==id)
                {
                    return _contex.Claims[i];
                }
            }
            return null;
        }

        public Claim Update(Claim obj)
        {
            var nCl=new Claim {Id = obj.Id, IdPermission = obj.IdPermission, IdRole = obj.IdRole, Policy = obj.Policy };
            for (int i = 0; i < _contex.Claims.Count; i++)
            {
                if (_contex.Claims[i].Id==obj.Id)
                {
                    _contex.Claims[i] = nCl;
                    return nCl;
                }
            }
            return null;
        }
    }
}
