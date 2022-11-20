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
    internal class PermissionService : IPermissionService
    {
        private readonly IRepositoryPermission _repositoryPermission;
        private readonly IMapper _mapper;
        public PermissionService(IRepositoryPermission repositoryPermission,IMapper mapper)
        {
            _repositoryPermission = repositoryPermission;
            _mapper = mapper;
        }

        public PermissionDTO Add(int id, string name, string description)
        {
            return _mapper.Map<PermissionDTO>(_repositoryPermission.Add(id,name,description));
        }

        public void Delete(int id)
        {
            _repositoryPermission.Delet(id);
        }

        public List<PermissionDTO> GetAll()
        {
            return _mapper.Map<List<PermissionDTO>>( _repositoryPermission.GetAll());
        }

        public PermissionDTO GetById(int id)
        {
            return _mapper.Map<PermissionDTO>( _repositoryPermission.GetById(id));
        }

        public PermissionDTO Update(PermissionDTO permission)
        {
            Permission pTemp = _mapper.Map<Permission>(permission);
            return _mapper.Map<PermissionDTO>(_repositoryPermission.Update(pTemp));
        }
    }
}
