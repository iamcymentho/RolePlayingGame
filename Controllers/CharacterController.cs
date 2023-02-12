using Microsoft.AspNetCore.Mvc;
using RolePlayingGame.Models;

namespace RolePlayingGame.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet]
        public ActionResult<Character> GetKnight()
        {
            return Ok(knight);
        }
        
    }
}