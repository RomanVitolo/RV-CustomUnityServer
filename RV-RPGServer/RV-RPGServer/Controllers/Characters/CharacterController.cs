using Microsoft.AspNetCore.Mvc;
using RV_RPGServer.Entities;

namespace RV_RPGServer.Controllers.Characters
{
    [ApiController]
    [Route("api/characters")]
    public class CharacterController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return new List<Character>
            {
                new Character{Id = 1, Name = "Paladin"},
                new Character{Id = 2, Name = "Mage"},
            };
        }
    }
}