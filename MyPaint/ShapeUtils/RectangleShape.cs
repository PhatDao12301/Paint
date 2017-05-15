using Paint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    class RectangleShape : Shape
    {

        private Pen mPen;
        private SolidBrush mBrush;
        protected Graphics mGraphic;
        private Rectangle mRectangle;
        private Point start;
        private Point end;

        protected Pen MPen
        {
            get
            {
                return mPen;
            }

            set
            {
                mPen = value;
            }
        }

        protected SolidBrush MBrush
        {
            get
            {
                return mBrush;
            }

            set
            {
                mBrush = value;
            }
        }

        public Point Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public Point End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        public Rectangle getRectangle(Point start, Point end)
        {
            return new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(start.X - end.X),
                Math.Abs(start.Y - end.Y));
        }

        public RectangleShape()
        {
        }

        public RectangleShape(Rectangle rect)
        {
            this.mRectangle = rect;
        }

        public RectangleShape(Pen p, Point startP, Point endP)
        {
            this.Start = startP;
            this.End = endP;
            this.MPen = new Pen(p.Color, p.Width);
        }

        public override void draw(PaintEventArgs e)
        {
            this.mGraphic = e.Graphics;
            mGraphic.DrawRectangle(MPen, getRectangle(Start, End));            
        }

        public override void draw(Pen p, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(p, getRectangle(Start, End));
            mGraphic = e.Graphics;
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(p, getRectangle(startPoint, endPoint));
            Start = startPoint;
            End = endPoint;
            this.MPen = new Pen(p.Color, p.Width);
            mGraphic = e.Graphics;
        }

        public override void draw()
        {
            if (!this.mRectangle.Equals(null))
                mGraphic.DrawRectangle(MPen, this.mRectangle);
        }
    }
}
