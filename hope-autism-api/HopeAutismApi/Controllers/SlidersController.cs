using HopeAutismApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HopeAutismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private static List<Slider> Sliders = new List<Slider>
        {
            new Slider { Id = 1, Title ="", Description ="", thumb="", LinkUrl="", Status = 0 },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Slider>> Get()
        {
            return Sliders;
        }

        [HttpGet("{id}")]
        public ActionResult<Slider> Get(int id)
        {
            var slider = Sliders[id];
            if (slider == null)
            {
                return NotFound();
            }
            return slider;
        }

        [HttpPost]
        public ActionResult<Slider> Post(Slider Slider)
        {
            Slider.Id = Sliders.Count + 1;
            Sliders.Add(Slider);
            return CreatedAtAction(nameof(Get), new { id = Slider.Id }, Slider);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var slider = Sliders.FirstOrDefault(s => s.Id == id);
            if (slider == null)
            {
                return NotFound();
            }
            Sliders.Remove(slider);
            return NoContent();
        }
    }
}
