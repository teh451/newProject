using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System.Security.Claims;
using Claim = MyProject.Repositories.Entities.Claim;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IRepositoryClaim _repositoryClaim;
        public ClaimController(IRepositoryClaim repositoryClaim)
        {
            _repositoryClaim = repositoryClaim;
        }
        [HttpGet]
        public List<Claim> Get()
        {
            return _repositoryClaim.GetAll();
        }
        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            return _repositoryClaim.GetById(id);
        }
        [HttpPost]
        public void Post(Claim c)
        {
            _repositoryClaim.Update(c);
        }
        [HttpPut]
        public void Put(Claim c)
        {
            _repositoryClaim.Add(c.Id, c.IdPermission, c.IdRole,c.Policy);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _repositoryClaim.Delet(id);
        }
    }
}
