using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordscapes.Models;


namespace Wordscapes.GameModes
{
    public abstract class GameMode
    {
        public abstract Level GetNextLevel();
        public abstract bool IsFinished();
    }
}
