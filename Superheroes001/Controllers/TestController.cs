using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheroes001.Entities;

namespace Superheroes001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Der findes en klasse, som generer det kode der skal til
    // for at en webside bliver vist
    public class TestController : ControllerBase
    {

        Hero h = new Hero
        {
            Id = 1,
            DebutYear = DateTime.Now,
            Name = "OMG Søren",
            Place = "I Dunno",
            RealName = "The best samurai in the .."
        };
        //[HttpGet] // REST, HTTP, Endpoint , mm.
        //public string Mytest() { return "this is a test"; }

        [HttpGet]
        public Hero heroReturn() { return h; }

        [HttpGet("Patirck")]
        public string[] arrayReturn()
        {
            return
                new string[] { "bla", "hippi"
                };
        }
    }
}
