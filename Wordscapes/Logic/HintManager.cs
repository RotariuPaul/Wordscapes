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
        public bool RevealRandomLetter(Level level, List<string> foundWords)
        {
            List<GridWord> hiddenWords = level.GridWords
                .Where(gridWord => !foundWords.Contains(gridWord.Word))
                .ToList();

            foreach (GridWord word in hiddenWords)
            {
                bool revealed = level.Grid.RevealOneLetter(word);

                if (revealed)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
