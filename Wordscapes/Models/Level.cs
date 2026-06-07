using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordscapes.Models
{
    public class Level
    {
        public int LevelNumber { get; private set; }
        public List<char> Letters { get; private set; }
        public List<string> Words { get; private set; }
        public int TimeLimitSeconds { get; private set; }
        public List<GridWord> GridWords { get; private set; }
        public Level(int levelNumber, List<char> letters, List<string> words, List<GridWord> gridWords, int timeLimitSeconds)
        {
            LevelNumber = levelNumber;
            Letters = letters;
            Words = words;
            TimeLimitSeconds = timeLimitSeconds;
            GridWords = gridWords;
        }
        public bool ContainsWord(string word)
        {
            return Words.Contains(word.ToUpper());
        }
    }
}
