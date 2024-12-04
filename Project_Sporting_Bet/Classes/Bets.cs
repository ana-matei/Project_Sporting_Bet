using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sporting_Bet.Classes
{
    [Serializable]
    public class Bets
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public string BetTeam { get; set; }


        public Bets(int iD, int amount,  string betTeam)    
        {
            ID = iD;
            Amount = amount;
            BetTeam = betTeam;
        }
    }
}
