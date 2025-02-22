using Microsoft.AspNetCore.Mvc;
using AlparRP.Models;
using Microsoft.EntityFrameworkCore;
using AlparRP.Data;

namespace AlparRP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscordUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DiscordUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DiscordUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiscordUser>>> GetDiscordUsers()
        {
            return await _context.DiscordUsers.ToListAsync();
        }

        // GET: api/DiscordUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DiscordUser>> GetDiscordUser(int id)
        {
            var discordUser = await _context.DiscordUsers.FindAsync(id);

            if (discordUser == null)
            {
                return NotFound();
            }

            return discordUser;
        }
    }
}
