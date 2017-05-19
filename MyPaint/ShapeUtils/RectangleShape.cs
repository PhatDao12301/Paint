using Paint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyPaint
{
    class RectangleShape : Shape
    {

        private Pen mPen;        
        protected Graphics mGraphic;
        private Rectangle mRectangle;
        private Point start;
        private Point end;
        private SolidBrush sb;
        private LinearGradientBrush lgb;

        private int colorFilled = 0;

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
            paintColor();
        }


        // paint the color for the retangle
        public bool paintColor()
        {
            switch (colorFilled)
            {
                case 1:
                    {
                        mGraphic.FillRectangle(sb, getRectangle(start, end));
                        return true;
                    }
                case 2:
                    {
                        mGraphic.FillRectangle(lgb, getRectangle(start, end));
                        return true;
                    }
                default: break;
            }
            return false;
        }

        public override void draw(Pen p, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(p, getRectangle(Start, End));
            mGraphic = e.Graphics;
            paintColor();
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(p, getRectangle(startPoint, endPoint));
            Start = startPoint;
            End = endPoint;
            this.MPen = new Pen(p.Color, p.Width);
            mGraphic = e.Graphics;
            paintColor();
        }
        public override void draw(Pen p, Point startPoint, Point endPoint, Graphics g)
        {

            mGraphic = g;
            this.MPen = new Pen(p.Color, p.Width);
            Start = startPoint;
            End = endPoint;
            mGraphic.DrawRectangle(p, getRectangle(startPoint, endPoint));

            //paintColor();
        }

        public override void draw()
        {
            if (!this.mRectangle.Equals(null))
            {               
                mGraphic.DrawRectangle(MPen, this.mRectangle);
                paintColor();                
            }
        }

        public override void fillColor(Color color)
        {
            sb = new SolidBrush(color);
            colorFilled = 1;
            mGraphic.FillRectangle(sb,getRectangle(start, end));
        }

        public override void fillColor(Color x, Color y)
        {
            lgb = new LinearGradientBrush(start, end, x, y);
            colorFilled = 2;
            mGraphic.FillRectangle(lgb, getRectangle(start, end));
        }
       
    }
}
