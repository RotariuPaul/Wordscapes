using System;
using System.Collections.Generic;
using System.Linq;
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
                ),

                new Level(
                    2,
                    new List<char> { 'C', 'A', 'S', 'A' },
                    new List<string> { "CASA", "ASA", "SAC" },
                    new List<GridWord>
                    {
                        new GridWord("CASA", 0, 0, true),
                        new GridWord("ASA", 0, 1, false),
                        new GridWord("SAC", 2, 0, true)
                    },
                    120
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
        public int LevelCount
        {
            get { return levels.Count; }
        }
    }
}