namespace SuperHeroAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            //<List<SuperHero> -> return value...

            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
