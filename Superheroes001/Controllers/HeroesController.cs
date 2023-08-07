using Microsoft.AspNetCore.Mvc;
using Superheroes001.EF;
using Superheroes001.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Superheroes001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        DatabaseContext context { get; set; }
        // the parametre in this method is called Dependency Injection
        public HeroesController(DatabaseContext bandit)
        {
            context = bandit;
        }
        /// <summary>
        /// how to generate sql script: 
        /// add-migration someName
        /// update-database
        /// </summary>
        /// <returns></returns>
        // GET: api/<HeroesController>
        [HttpGet]
        public ActionResult<Hero> GetAllHardcoded()
        {
            Hero hero = new Hero
            {
                Id = 1,
                DebutYear = DateTime.Now,
                Name = "OMG Søren",
                Place = "I Dunno",
                RealName = "The best samurai in the .."
            };
            return hero;
        }

        [HttpGet("all")]
        public ActionResult<Hero> GetAll()
        {
            List<Hero> list = new List<Hero>();
            list = context.Hero.ToList();
            return Ok(list);
            //return (Hero)list; // convert lort!!
            //return list;

        }

        // GET api/<HeroesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HeroesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HeroesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HeroesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
