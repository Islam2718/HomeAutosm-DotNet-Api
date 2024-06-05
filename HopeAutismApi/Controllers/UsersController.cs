using HopeAutismApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HopeAutismApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "John Doe", Email = "john@example.com" },
            new User { Id = 2, Username = "Jane Smith", Email = "jane@example.com"},
        };

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Users;
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = Users[id];
            if(user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public ActionResult<User> Post(User user)
        {
            user.Id = Users.Count + 1;
            Users.Add(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            Users.Remove(user);
            return NoContent();
        }
    }
}
