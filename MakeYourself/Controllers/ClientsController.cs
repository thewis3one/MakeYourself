using MakeYourself.Dto;
using MakeYourself.Models;
using MakeYourself.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeYourself.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IService _service;

        public ClientsController(AppDbContext appDbContext, IService service)
        {
            _appDbContext = appDbContext;
            _service = service;
        }

        

        // POST api/<ClientsController>
        [HttpPost]
        [Route("/register")]
        public async Task<IActionResult> Register([FromBody] ClientRegistrationDto registraionData)
        {
            if (_appDbContext.Clients.Any(x => x.Login == registraionData.Login))
            {
                return BadRequest("Sosi!");
            }

            var client = new Client()
            {
                FIO = registraionData.FIO,
                DateOfBirth = registraionData.DateOfBirth,
                Weight = registraionData.Weight,
                Height = registraionData.Height,
                PhysiqueId = registraionData.BuildTypeId,
                Login = registraionData.Login,
                Password = registraionData.Password
            };

            await _appDbContext.Clients.AddAsync(client);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { client.Id });
        }

        [HttpPost]
        [Route("/auth")]
        public async Task<IActionResult> Auth([FromBody] ClientAuthDto authData)
        {
                var client = await _appDbContext.Clients
                .Where(x => x.Login == authData.Login && x.Password == authData.Password)
                .Select(x => new { x.Id, x.FIO, x.DateOfBirth, x.Weight, x.Height, x.PhysiqueId })
                .FirstOrDefaultAsync();
            
            if (client != null)
            {
                string physique = await _appDbContext.Physiques
                    .Where(x => x.Id == client.PhysiqueId)
                    .Select(x => x.Name)
                    .FirstOrDefaultAsync();

                return Ok(new {client.Id, client.FIO, client.DateOfBirth, client.Weight, client.Height, physique});
            }
            else
            {
                return BadRequest("Неверный логин или пароль");
            }

        }

        [HttpPut]
        [Route("/edit/{Id}")]
        public async Task<IActionResult> EditProfile([FromBody] ClientEditProfileDto editData, [FromRoute] int Id)
        {
            var client = await _appDbContext.Clients
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync();

            client.FIO = editData.FIO;
            client.DateOfBirth = editData.DateOfBirth;
            client.Weight = editData.Weight;
            client.Height = editData.Height;
            client.PhysiqueId = editData.BuildTypeId;

            await _appDbContext.SaveChangesAsync();
            return Ok(Id);
        }
    }
}
