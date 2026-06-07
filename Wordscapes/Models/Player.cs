using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordscapes.Models
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; private set; }
        public int CurrentLevel { get; private set; }
        public Player(string name)
        {
            Name = name;
            Score = 0;
            CurrentLevel = 1;
        }
        public void AddScore(int points)
        {
            if(points>0)
                Score += points;
        }
        public void AdvanceLevel()
        {
            CurrentLevel++;
        }
        public void ResetScore()
        {
            Score = 0;
        }
       
    }
}
