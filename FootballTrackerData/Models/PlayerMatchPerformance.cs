using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTrackerData.Models
{
    public class PlayerMatchPerformance
    {
        public int PlayerMatchPerformanceId {  get; set; }
        public int MinutesPlayed { get; set; }
        public int PlayersRating {  get; set; }
        public int Goals {  get; set; }
        public int Assists {  get; set; }
        
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int MatchId { get; set; }
        public Match Match {  get; set; }

        public string? InjuryNotes {  get; set; }


    }
}
