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
        /// <summary>
        /// Tuesday
        /// List Hero => LINQ 3-7
        /// Lambda
        /// - Opgaver
        /// 
        /// </summary>
        DatabaseContext context { get; set; }

        List<Hero> heroes;

        // the parametre in this method is called Dependency Injection
        public HeroesController(DatabaseContext bandit)
        {
            context = bandit;
            heroes = new List<Hero>()
            {
                new Hero{Id=1, Name = "Phill", DebutYear= Convert.ToDateTime("12-12-2023"), Place = "Ballerup" ,
                    RealName = "Julemanden" },
                new Hero{Id=2, Name = "Anna", DebutYear= Convert.ToDateTime("01-03-2023"), Place = "Grønland" ,
                    RealName = "Batman" },
                new Hero{Id=10, Name = "Mai", DebutYear= Convert.ToDateTime("08-08-2023"), Place = "Danmark" ,
                    RealName = "Superman" },
            };
        }
        /// <summary>
        /// 

        #region monday









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

        #endregion monday
        #region tuesday
        // method that loop the list and find Id == 2, foreach , if 

        [HttpGet("MethodWithForeach")]
        public ActionResult<Hero> methodThatUseForeach()
        {
            foreach (var hero in heroes)
            {
                if (hero.Id == 2) { return hero; }
            }
            return BadRequest();
        }
   

        [HttpGet("MethodWithLINQ")]      
        public ActionResult<Hero> methodThatUseLINQ()
        {
            var hero = heroes.Where(hero => hero.Id == 88).FirstOrDefault();
            return hero;
        }
        /// <summary>
        /// LINQ is used on Collections
        /// LINQ generate a query but is not Executed
        /// There are several ways to Execute a LINQ statement
        /// </summary>
        /// <returns></returns>


        [HttpGet("MethodWithLINQMaxId")]
        public ActionResult<Hero> methodThatUseLINQMaxId()
        {
            var hero = heroes.MaxBy(flødebolle=> flødebolle.Id);
            return Ok(hero);
        }

        [HttpGet("MethodWithLINQMaxId002")]
        public ActionResult<Hero> methodThatUseLINQMaxId002()
        {
            var heroId = heroes.Max(flødebolle => flødebolle.Id);
            var hero = heroes.Where(hero => hero.Id == heroId).FirstOrDefault();


            var oneLine = heroes.Where(hero => hero.Id 
                == heroes.Max(flødebolle => flødebolle.Id)).FirstOrDefault();
            return Ok(hero);
        }
        #endregion tuesday
    }
}
