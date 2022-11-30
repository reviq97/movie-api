using Microsoft.AspNetCore.Mvc;
using movie_api.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movie_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{title}")]
        public string Get(string title)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
        }

        
    }
}
