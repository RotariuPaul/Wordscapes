using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordscapes.Models
{
    public class GridCell
    {
        public char Letter { get; private set; }
        public bool IsVisible { get; private set; }
        public bool IsRevealed { get; private set; }

        public GridCell(char letter)
        {
            Letter = letter;
            IsVisible = true;
            IsRevealed = false;
        }
        public void Reveal()
        {
            IsRevealed = true;
        }
    }
}
