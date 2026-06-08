using System.Drawing;
using System.Windows.Forms;

namespace Wordscapes.Controls
{
    public class LetterWheelControl : Control
    {
        public List<char> Letters { get; private set; } = new List<char>();

        public event Action<string>? WordCompleted;

        private bool isDragging = false;
        private List<int> selectedIndexes = new List<int>();
        private Point currentMousePosition;

        public LetterWheelControl()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }
        public void SetLetters(List<char> letters)
        {
            Letters = letters;
            selectedIndexes.Clear();
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
          

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int centerX = Width / 2;
            int centerY = Height / 2;
            int radius = Math.Min(Width, Height) / 2 - 15;

            Rectangle circleRect = new Rectangle(
                centerX - radius,
                centerY - radius,
                radius * 2,
                radius * 2
            );

            using SolidBrush wheelBrush = new SolidBrush(Color.FromArgb(140, 255, 255, 255));
            using Pen wheelPen = new Pen(Color.FromArgb(180, 255, 255, 255), 2);

            g.FillEllipse(wheelBrush, circleRect);
            g.DrawEllipse(wheelPen, circleRect);

            if (Letters.Count == 0)
            {
                return;
            }

            List<Point> letterCenters = GetLetterCenters();

            using Pen linePen = new Pen(Color.DodgerBlue, 5);
            linePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            linePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            for (int i = 0; i < selectedIndexes.Count - 1; i++)
            {
                Point start = letterCenters[selectedIndexes[i]];
                Point end = letterCenters[selectedIndexes[i + 1]];

                g.DrawLine(linePen, start, end);
            }
            if (isDragging && selectedIndexes.Count > 0)
            {
                Point lastPoint = letterCenters[selectedIndexes[selectedIndexes.Count - 1]];
                g.DrawLine(linePen, lastPoint, currentMousePosition);
            }

            for (int i = 0; i < Letters.Count; i++)
            {
                Point center = letterCenters[i];
                Rectangle letterRect = new Rectangle(center.X - 25, center.Y - 25, 50, 50);

                Brush fillBrush = selectedIndexes.Contains(i) ? Brushes.LightBlue : Brushes.White;

                g.FillEllipse(fillBrush, letterRect);
               

                using Font font = new Font(Font.FontFamily, 18, FontStyle.Bold);
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                g.DrawString(
                    Letters[i].ToString(),
                    font,
                    Brushes.Black,
                    letterRect,
                    format
                );
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            isDragging = true;
            selectedIndexes.Clear();
            currentMousePosition = e.Location;

            AddLetterFromPosition(e.Location);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (isDragging)
            {
                currentMousePosition = e.Location;
                AddLetterFromPosition(e.Location);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            isDragging = false;

            string word = "";

            foreach (int index in selectedIndexes)
            {
                word += Letters[index];
            }

            selectedIndexes.Clear();
            Invalidate();

            if (word.Length > 0)
            {
                WordCompleted?.Invoke(word);
            }
        }

        private void AddLetterFromPosition(Point mousePosition)
        {
            List<Point> letterCenters = GetLetterCenters();

            for (int i = 0; i < letterCenters.Count; i++)
            {
                Rectangle letterRect = new Rectangle(
                    letterCenters[i].X - 25,
                    letterCenters[i].Y - 25,
                    50,
                    50
                );

                if (letterRect.Contains(mousePosition) && !selectedIndexes.Contains(i))
                {
                    selectedIndexes.Add(i);
                    Invalidate();
                    break;
                }
            }
        }

        private List<Point> GetLetterCenters()
        {
            List<Point> centers = new List<Point>();

            int centerX = Width / 2;
            int centerY = Height / 2;
            int radius = Math.Min(Width, Height) / 2 - 15;

            for (int i = 0; i < Letters.Count; i++)
            {
                double angle = 2 * Math.PI * i / Letters.Count - Math.PI / 2;

                int x = centerX + (int)(Math.Cos(angle) * radius * 0.78);
                int y = centerY + (int)(Math.Sin(angle) * radius * 0.78);

                centers.Add(new Point(x, y));
            }

            return centers;
        }
    }
}