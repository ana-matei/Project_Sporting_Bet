using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sporting_Bet.Classes
{
    [Serializable]
    public class Gambler
    {
        public int Id { get; set; }
        public string Name { get; set; }


        private List<Match> _match;
        private List<Bets> _bet;

        public Gambler(int id, string name)
        {
            Id = id;
            Name = name;
            _match = new List<Match>();
            _bet = new List<Bets>();
        }


        public List<Match> Match
        { get { return _match; } }

        public void AddMatch(Match match)
        {
            _match.Add(match);
        }
        public List<Bets> Bet
        {
            get { return _bet; }
        }

        public void AddBet(Bets bet)
        {
            _bet.Add(bet);
        }
    }
}
