using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Wordscapes.Models;

namespace Wordscapes.Controls
{
    public class PuzzleGridControl:Control 
    {
        public   PuzzleGrid? Grid { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Grid == null)
            {
                return;
            }

            Graphics g = e.Graphics;
            int cellSize = 40;

            int minRow = Grid.Rows;
            int maxRow = 0;
            int minColumn = Grid.Columns;
            int maxColumn = 0;

            for (int row = 0; row < Grid.Rows; row++)
            {
                for (int column = 0; column < Grid.Columns; column++)
                {
                    if (Grid.Cells[row, column] != null)
                    {
                        minRow = Math.Min(minRow, row);
                        maxRow = Math.Max(maxRow, row);
                        minColumn = Math.Min(minColumn, column);
                        maxColumn = Math.Max(maxColumn, column);
                    }
                }
            }

            int puzzleWidth = (maxColumn - minColumn + 1) * cellSize;
            int puzzleHeight = (maxRow - minRow + 1) * cellSize;

            int offsetX = (Width - puzzleWidth) / 2;
            int offsetY = (Height - puzzleHeight) / 2;

            for (int row = 0; row < Grid.Rows; row++)
            {
                for (int column = 0; column < Grid.Columns; column++)
                {
                    GridCell? cell = Grid.Cells[row, column];

                    if (cell == null)
                    {
                        continue;
                    }

                    int x = offsetX + (column - minColumn) * cellSize;
                    int y = offsetY + (row - minRow) * cellSize;

                    Rectangle rect = new Rectangle(x, y, cellSize, cellSize);

                    g.FillRectangle(Brushes.White, rect);
                    g.DrawRectangle(Pens.Black, rect);

                    if (cell.IsRevealed)
                    {
                        StringFormat format = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };

                        g.DrawString(cell.Letter.ToString(), Font, Brushes.Black, rect, format);
                    }
                }
            }
        
        }
    }
}
