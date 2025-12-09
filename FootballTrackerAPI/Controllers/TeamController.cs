using FootballTrackerData.Data;
using FootballTrackerData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly FootballDbContext _context;
        public TeamController(FootballDbContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Team>>> GetTeams() 
        {
            var teams = await _context.Team.OrderByDescending(t => t.TeamName).ToListAsync();
            return Ok(teams);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSelectedTeam(int id) 
        {
            var selectedTeam = _context.Team.FindAsync(id);
            if (selectedTeam == null) 
            {
                return NotFound();
            }
            return Ok(selectedTeam);
        }




    }
}
