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
using ePolicy = MyProject.Repositories.Entities.ePolicy;
using ePolicyDTO = MyProject.Common.DTOs.ePolicy;

namespace MyProject.Services.Services
{
    public class ClaimService : IClaimService
    {
        private readonly IRepositoryClaim _repositoryClaim;
        private readonly IMapper _mapper;
        public ClaimService(IRepositoryClaim repositoryClaim,IMapper mapper)
        {
            _repositoryClaim = repositoryClaim;
            _mapper = mapper;
        }
        public ClaimDTO Add(int id,  PermissionDTO permission, RoleDTO role, ePolicyDTO policy)
        {
            Permission pTemp=_mapper.Map<Permission>(permission);
            Role rT = _mapper.Map<Role>(role);
            return _mapper.Map<ClaimDTO> (_repositoryClaim.Add(id,pTemp,rT,_mapper.Map<ePolicy>(policy)));
        }

        public void Delete(int id)
        {
            _repositoryClaim.Delet(id);
        }

        public List<ClaimDTO> GetAll()
        {
            return _mapper.Map<List<ClaimDTO>>(_repositoryClaim.GetAll());
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_repositoryClaim.GetById(id));
        }

        public ClaimDTO Update(ClaimDTO claim)
        {
            Claim c=_mapper.Map<Claim>(claim);
            return  _mapper.Map<ClaimDTO>(_repositoryClaim.Update(c));
        }
    }
}
