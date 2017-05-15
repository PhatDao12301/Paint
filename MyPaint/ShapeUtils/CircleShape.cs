using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    class CircleShape : EllipseShape
    {
        private Pen mPen1;
        private Graphics mGraphic;
        private Rectangle mRectangle;
        private Point start;
        private Point end;

        protected Pen MPen1
        {
            get
            {
                return mPen1;
            }

            set
            {
                mPen1 = value;
            }
        }

        protected Graphics MGraphic
        {
            get
            {
                return mGraphic;
            }

            set
            {
                mGraphic = value;
            }
        }

        public Rectangle MRectangle
        {
            get
            {
                return mRectangle;
            }

            set
            {
                mRectangle = value;
            }
        }

        public Point Start1
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

        public Point End1
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

        public Rectangle getSquare(Point start, Point end)
        {
            return new Rectangle(
      Math.Min(start.X, end.X),
      Math.Min(start.Y, end.Y),
      Math.Abs(start.X - end.X),
      Math.Abs(start.X - end.X));
        }

        public CircleShape()
        {
        }

        public CircleShape(Rectangle rect)
        {
            this.MRectangle = rect;
        }
        public CircleShape(Pen p, Point startP, Point endP)
        {
            this.Start1 = startP;
            this.End1 = endP;
            this.MPen1 = new Pen(p.Color, p.Width);
        }

        public override void draw(PaintEventArgs e)
        {
            this.MGraphic = e.Graphics;
            MGraphic.DrawEllipse(MPen1, getSquare(Start1, End1));
            
        }

        public override void draw(Pen p, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(p, getSquare(Start1, End1));
            this.MPen1 = new Pen(p.Color, p.Width);
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(p, getSquare(startPoint, endPoint));
            Start1 = startPoint;
            End1 = endPoint;
            this.MPen1 = new Pen(p.Color, p.Width);

        }
    }
}
