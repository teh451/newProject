using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRepositoryRole _repositoryRole;
        public RolesController(IRepositoryRole repositoryRole)
        {
            _repositoryRole = repositoryRole;
        }
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _repositoryRole.GetAll();
        }
        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            return _repositoryRole.GetById(id);
        }
        [HttpPost]
        public void Post(Role role)
        { 
            _repositoryRole.Update(role);
        }
        [HttpPut]
        public void Put(Role role) 
        {
            _repositoryRole.Add(role.Id, role.Name, role.Descripsion);
        }
        [HttpDelete]
        public void Delete(int id)
        { 
            _repositoryRole.Delet(id);
        }
    }
}
