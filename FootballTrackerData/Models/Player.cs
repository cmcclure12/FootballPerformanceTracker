using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTrackerData.Models
{
    public class Player
    {
        public int PlayerId {  get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public string Position {  get; set; }
        public bool IsInjured {  get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public ICollection<PlayerMatchPerformance> Performances { get; set; }

    }
}
