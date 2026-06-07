using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordscapes.Models;

namespace Wordscapes.Logic
{
    public class LevelManager
    {
        private List<Level> levels;
        public LevelManager()
        {
            levels = new List<Level>
            {
               new Level(
    1,
    new List<char> { 'A', 'R', 'E' },
    new List<string> { "ARE", "ERA" },
    new List<GridWord>
    {
        new GridWord("ARE", 0, 0, true),
        new GridWord("ERA", 0, 2, false)
    },
    90
)
            };
        }
        public Level GetLevel(int levelNumber)
        {
            Level? level = levels.FirstOrDefault(level => level.LevelNumber == levelNumber);

            if (level == null)
            {
                throw new Exception("Nivelul nu există.");
            }

            return level;
        }
    }
}
