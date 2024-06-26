using HopeAutismApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HopeAutismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteinfosController : ControllerBase
    {
        private static List<Siteinfo> Siteinfos = new List<Siteinfo> 
        {
            new Siteinfo { Id = 1, Name = "Hope Autism Welfare", Title = "Hope Autism Walefare Trust School" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Siteinfo>> Get()
        {
            return Siteinfos;
        }

        [HttpGet("{id}")]
        public ActionResult<Siteinfo> Get(int id)
        {
            var siteinfo = Siteinfos[id];
            if (siteinfo == null)
            {
                return NotFound();
            }
            return siteinfo;
        }

        [HttpPost]
        public ActionResult<Siteinfo> Post(Siteinfo siteinfo)
        {
            siteinfo.Id = Siteinfos.Count + 1;
            Siteinfos.Add(siteinfo);
            return CreatedAtAction(nameof(Get), new { id = siteinfo.Id }, siteinfo);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var siteinfo = Siteinfos.FirstOrDefault(s => s.Id == id);
            if (siteinfo == null)
            {
                return NotFound();
            }
            Siteinfos.Remove(siteinfo);
            return NoContent();
        }
    }
}
