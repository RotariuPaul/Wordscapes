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
                Score += points;
            if (Score < 0)
            {
                Score = 0;
            }
        }
        public void AdvanceLevel()
        {
            CurrentLevel++;
        }
        public void ResetScore()
        {
            Score = 0;
        }
        public void RemoveScore(int points)
        {
            Score -= points;

            if (Score < 0)
            {
                Score = 0;
            }
        }
        public void ChangeName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                Name = newName;
            }
        }
    }
}
