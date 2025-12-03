using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTrackerData.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        public string Opponent {  get; set; }
        public DateOnly Date {  get; set; }
        public bool isHomeMatch {  get; set; } //Home or away
        public int? TeamGoals {  get; set; } // goals scored by users team
        public int? OpponentGoals {  get; set; } //Goals conceded

        public int TeamId {  get; set; }
        public Team Team { get; set; }
        public ICollection<PlayerMatchPerformance> PlayerPerformances { get; set; }

    }
}
