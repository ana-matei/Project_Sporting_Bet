using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sporting_Bet.Classes
{
    [Serializable]
    public class Match
    {
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public DateTime Date { get; set; }
        public bool IsTheFinal { get; set; }

        public Match(string teamA, string teamB, DateTime date, bool isTheFinal)
        {
            TeamA = teamA;
            TeamB = teamB;
            Date = date;
            IsTheFinal = isTheFinal;
        }
    }


}
