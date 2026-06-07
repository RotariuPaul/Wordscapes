using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordscapes.Models
{
    public class GridWord
    {
        public string Word { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }
        public bool IsHorizontal { get; private set; }
        public GridWord(string word,int row, int column , bool isHorizontal)
        {
            Word = word.ToUpper();
            Row = row;
            Column = column;
            IsHorizontal = isHorizontal;
        }
    }
}
