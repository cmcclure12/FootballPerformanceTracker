using FootballTrackerData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTrackerData.Data
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options) 
        {
        }

        public DbSet<Match> Match {  get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<PlayerMatchPerformance> playerMatchPerformances { get; set; }
        public DbSet<Team> Team { get; set; }
    }
}
