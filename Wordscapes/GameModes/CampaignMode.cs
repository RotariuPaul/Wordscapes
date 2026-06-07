using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordscapes.Models;
using Wordscapes.Logic;

namespace Wordscapes.GameModes
{
    public class CampaignMode : GameMode
    {
        private LevelManager levelManager;
        private int currentLevelNumber;
        public CampaignMode()
        {
            levelManager = new LevelManager();
            currentLevelNumber = 1;
        }
        public override Level GetNextLevel()
        {
            Level level = levelManager.GetLevel(currentLevelNumber);
            currentLevelNumber++;
            return level;
        }

        public override bool IsFinished()
        {
            return currentLevelNumber > 2;
        }
    }
}
