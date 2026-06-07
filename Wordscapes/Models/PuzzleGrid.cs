using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordscapes.Models
{
    public class PuzzleGrid
    {
        public GridCell?[,] Cells { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public PuzzleGrid(List <GridWord> gridWords)
        {
            Rows = 10;
            Columns = 10;
            Cells = new GridCell?[Rows, Columns];

            foreach (GridWord gridWord in gridWords)
            {
                AddWord(gridWord);
            }
        }

        public void AddWord(GridWord gridWord)
        {
            for (int i = 0; i < gridWord.Word.Length; i++)
            {
                int row = gridWord.Row;
                int column = gridWord.Column;
                if (gridWord.IsHorizontal)
                {
                    column += i;
                }
                else
                {
                    row += i;
                }
                Cells[row, column] = new GridCell(gridWord.Word[i]);
            }
        }
    }
}
