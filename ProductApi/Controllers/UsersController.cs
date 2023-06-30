using Microsoft.AspNetCore.Mvc;
using ProductApi.Models.Users;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static readonly Dictionary<Guid, User> users = new();

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(users);
        }

        [HttpPost]
        public ActionResult Post()
        {
            // Lead

            Guid userId = Guid.NewGuid();

            User userAsLead = new Lead("email@email.com");

            users[userId] = userAsLead;

            // Contact

            // Account

            return Ok();
        }
    }
}