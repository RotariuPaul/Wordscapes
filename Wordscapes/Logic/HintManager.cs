using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordscapes.Models;

namespace Wordscapes.Logic
{
    public class HintManager
    {
        public bool RevealRandomLetter(Level level,List<string> foundWords)
        {
            List<GridWord> hiddenWords = level.GridWords.Where(GridWord => !foundWords.Contains(GridWord.Word)).ToList();
            if (hiddenWords.Count == 0)
                return false;
            GridWord word = hiddenWords[0];
            level.Grid.RevealWord(word);
            return true;
        }
    }
}
