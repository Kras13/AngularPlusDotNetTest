namespace SuperHeroAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    //[Route("[controller]/[action]")]
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        [HttpGet]
        
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            //<List<SuperHero> -> return value...

            return new List<SuperHero>
            {
                new SuperHero
                {
                    Name = "Spider-Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
