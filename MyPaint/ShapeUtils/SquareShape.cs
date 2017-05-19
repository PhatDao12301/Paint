using Paint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    class SquareShape : Shape
    {
        private Pen mPen1;
        private Graphics mGraphic;
        private Rectangle Square;
        private Point start;
        private Point end;
        private SolidBrush sb;
        private LinearGradientBrush lgb;

        private int colorFilled = 0;

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

        public Rectangle Square1
        {
            get
            {
                return Square;
            }

            set
            {
                Square = value;
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

        public SquareShape(Pen p, Point startP, Point endP)
        {
            this.Start1 = startP;
            this.End1 = endP;
            this.MPen1 = new Pen(p.Color, p.Width);
        }

        public Rectangle getSquare(Point start, Point end)
        {

            return new Rectangle(
                          Math.Min(start.X, end.X),
                          Math.Min(start.Y, end.Y),
                          Math.Abs(start.X - end.X),
                          Math.Abs(start.X - end.X));
        }

        // paint the color for the retangle
        public bool paintColor()
        {
            switch (colorFilled)
            {
                case 1:
                    {
                        mGraphic.FillRectangle(sb, getSquare(start, end));
                        return true;
                    }
                case 2:
                    {
                        mGraphic.FillRectangle(lgb, getSquare(start, end));
                        return true;
                    }
                default: break;
            }
            return false;
        }

        public override void draw(PaintEventArgs e)
        {
            this.MGraphic = e.Graphics;
            MGraphic.DrawRectangle(MPen1, getSquare(Start1, End1));
            paintColor();
        }

        public override void draw()
        {
            if (!this.Square1.Equals(null))
            {
                MGraphic.DrawRectangle(MPen1, this.Square1);
                paintColor();
            }
        }


        public override void draw(Pen p, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(p, getSquare(Start1, End1));
            this.MPen1 = new Pen(p.Color, p.Width);
            paintColor();
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(p, getSquare(startPoint, endPoint));
            Start1 = startPoint;
            End1 = endPoint;
            this.MPen1 = new Pen(p.Color, p.Width);
            paintColor();
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, Graphics g)
        {
            mGraphic = g;
            this.mPen1 = new Pen(p.Color, p.Width);
            start = startPoint;
            end = endPoint;
            mGraphic.DrawRectangle(p, getSquare(startPoint, endPoint));

            //paintColor();
        }

        public override void fillColor(Color color)
        {
            sb = new SolidBrush(color);
            colorFilled = 1;
            mGraphic.FillRectangle(sb, getSquare(start, end));
        }

        public override void fillColor(Color x, Color y)
        {
            lgb = new LinearGradientBrush(start, end, x, y);
            colorFilled = 2;
            mGraphic.FillRectangle(lgb, getSquare(start, end));
        }
    }
}
