using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTrackerData.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName {  get; set; }

        public ICollection<Player> Player {  get; set; }
        public ICollection<Match>Match { get; set; }
    }
}
