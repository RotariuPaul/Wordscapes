using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordscapes.Models
{
    public class SaveData
    {
        public string PlayerName { get; set; } = "";
        public int Score { get; set; }
        public int CurrentLevelNumber { get; set; }
    }
}
