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
            if (Grid==null)
            {
                return;
            }
            Graphics g = e.Graphics;
            int cellSize = 40;
            for(int row=0;row<Grid.Rows;row++)
            {
                for (int column=0;column <Grid.Columns;column++)
                {
                    GridCell? cell = Grid.Cells[row, column];
                    if(cell==null)
                    {
                        continue;
                    }
                    int x = column * cellSize;
                    int y = row * cellSize;
                    Rectangle rect = new Rectangle(x, y, cellSize, cellSize);
                    g.FillRectangle(Brushes.White, rect);
                    g.DrawRectangle(Pens.Black, rect);
                }
            }
        }
    }
}
