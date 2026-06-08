using Wordscapes.Logic;
using Wordscapes.Models;

namespace Wordscapes.GameModes
{
    public class EndlessMode : GameMode
    {
        private int levelNumber;
        private LevelGenerator levelGenerator;

        public EndlessMode(LevelGenerator levelGenerator)
        {
            this.levelGenerator = levelGenerator;
            levelNumber = 1;
        }

        public override Level GetNextLevel()
        {
            Level level = levelGenerator.GenerateLevel(levelNumber);
            levelNumber++;

            return level;
        }

        public override bool IsFinished()
        {
            return false;
        }
    }
}