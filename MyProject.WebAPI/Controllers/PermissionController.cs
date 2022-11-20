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
    public class PermissionController : ControllerBase
    {
        private readonly IRepositoryPermission _repositoryPermission;
        public PermissionController(IRepositoryPermission repositoryPermission)
        {
            _repositoryPermission = repositoryPermission;
        }
        [HttpGet]
        public List<Permission> Get()
        {
            return _repositoryPermission.GetAll();
        }
        [HttpGet("{id}")]
        public Permission GetById(int id)
        {
            return _repositoryPermission.GetById(id);
        }
        [HttpPost]
        public void Post(Permission per)
        {
            _repositoryPermission.Update(per);
        }
        [HttpPut]
        public void Put(Permission per)
        {
            _repositoryPermission.Add(per.Id, per.Name, per.Descripsion);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _repositoryPermission.Delet(id);
        }
    }
}
