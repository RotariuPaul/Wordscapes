using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Wordscapes.Models;

namespace Wordscapes.GameModes
{
    public class EndlessMode : GameMode
    {
        private int levelNumber;
        public EndlessMode()
        {
            levelNumber = 1;
        }
        public override Level GetNextLevel()
        {
            Level level = new Level(
     levelNumber,
     new List<char> { 'A', 'R', 'E' },
     new List<string> { "ARE", "ERA" },
     new List<GridWord>
     {
        new GridWord("ARE", 0, 0, true),
        new GridWord("ERA", 0, 2, false)
     },
     90 + levelNumber * 10
 );

            levelNumber++;

            return level;
        }
        public override bool IsFinished()
        {
            return false;
        }

    }
}
