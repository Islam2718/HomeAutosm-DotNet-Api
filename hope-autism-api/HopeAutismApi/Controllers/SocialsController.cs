using HopeAutismApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HopeAutismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialsController : ControllerBase
    {
        private static List<Social> Socials = new List<Social>
        {
            new Social { Id = 1, Name = "Facebook", LinkUrl = "facebook.com/phicsart/", Icon = "fb.ico", Image = "", Target = "_blank", Status = 0 },
            new Social { Id = 2, Name = "Twitter", LinkUrl = "twitter.com/phicsart/", Icon = "tw.ico", Image = "", Target = "_blank", Status = 0 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Social>> Get()
        {
            return Socials;
        }

        [HttpGet("{id}")]
        public ActionResult<Social> Get(int id)
        {
            var social = Socials[id];
            if (social == null)
            {
                return NotFound();
            }
            return social;
        }

        [HttpPost]
        public ActionResult<Social> Post(Social Social)
        {
            Social.Id = Socials.Count + 1;
            Socials.Add(Social);
            return CreatedAtAction(nameof(Get), new { id = Social.Id }, Social);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var social = Socials.FirstOrDefault(s => s.Id == id);
            if (social == null)
            {
                return NotFound();
            }
            Socials.Remove(social);
            return NoContent();
        }
    }
}
