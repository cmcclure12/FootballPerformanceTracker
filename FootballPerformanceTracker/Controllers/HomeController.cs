using System.Diagnostics;
using FootballPerformanceTracker.Models;
using FootballTrackerData.Data;
using Microsoft.AspNetCore.Mvc;

namespace FootballPerformanceTracker.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly FootballDbContext _context;

        public HomeController(FootballDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var teams = _context.Team.ToList();
            return View(teams);
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
