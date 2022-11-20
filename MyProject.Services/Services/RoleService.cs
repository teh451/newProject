using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    internal class RoleService : IRoleService
    {
        private readonly IRepositoryRole _repositoryRole;
        private readonly IMapper _mapper;
        public RoleService(IRepositoryRole repositoryRole,IMapper mapper)
        {
            _repositoryRole = repositoryRole;
            _mapper = mapper;
        }

        public RoleDTO Add(int id, string name, string description)
        {
            Role role= _repositoryRole.Add(id, name, description);
            return _mapper.Map<RoleDTO>(role);
        }

        public void Delete(int id)
        {
            _repositoryRole.Delet(id);
        }

        public List<RoleDTO> GetAll()
        {
            return _mapper.Map<List<RoleDTO>>(_repositoryRole.GetAll());
        }

        public RoleDTO GetById(int id)
        {
            var role=_repositoryRole.GetById(id);
            return _mapper.Map<RoleDTO>(role);
        }

        public RoleDTO Update(RoleDTO role)
        {
            var tempR = _mapper.Map<Role>(role);
            return _mapper.Map<RoleDTO>( _repositoryRole.Update(tempR));
        }
    }
}
