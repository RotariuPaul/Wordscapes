using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordscapes.Models;

namespace Wordscapes.Logic
{
    public class Game
    {
        public Player Player { get; private set; }
        public Level CurrentLevel { get; private set; }
        public List<string> FoundWords { get; private set; }
        public int CurrentLevelScore { get; private set; }

        public Game(Player player, Level level)
        {
            Player = player;
            CurrentLevel = level;
            FoundWords = new List<string>();
            CurrentLevelScore = 0;
        }
        public bool TrySubmitWord(string word)
        {
            word = word.Trim().ToUpper();

            if (!CurrentLevel.ContainsWord(word))
                return false;

            if (FoundWords.Contains(word))
                return false;

            FoundWords.Add(word);

            GridWord? gridWord = CurrentLevel.GridWords.FirstOrDefault(gridWord => gridWord.Word == word);
            if (gridWord != null)
                CurrentLevel.Grid.RevealWord(gridWord);

            int points = word.Length * 10;
            CurrentLevelScore += points;
            Player.AddScore(points);
            return true;
            
        }
        public bool LevelCompleted()
        {
            return FoundWords.Count == CurrentLevel.Words.Count;
        }
    }

}
