using Paint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyPaint.ShapeUtils
{
    class LineShape : Shape
    {
        private Pen mPen;
        private Graphics mGraphic;
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

        protected Point Start
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

        protected Point End
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

        public LineShape()
        {
        }
       
        public LineShape(Pen p, Point startP, Point endP)
        {
            this.Start = startP;
            this.End = endP;
            this.MPen = new Pen(p.Color, p.Width);
        }

        public override void draw()
        {           
            MGraphic.DrawLine(MPen, Start, End);
        }

        public override void draw(PaintEventArgs e)
        {
            this.MGraphic = e.Graphics;            
            MGraphic.DrawLine(MPen, Start, End);
        }

        public override void draw(Pen p, PaintEventArgs e)
        {
            this.MPen = new Pen(p.Color, p.Width);
            this.MGraphic = e.Graphics;
            MGraphic.DrawLine(MPen, Start, End);
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e)
        {
            this.MPen = new Pen(p.Color, p.Width);
            this.Start = startPoint;
            this.End = endPoint;
            this.MGraphic = e.Graphics;
            MGraphic.DrawLine(p, startPoint, endPoint);
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, Graphics g)
        {
            mGraphic = g;
            this.MPen = new Pen(p.Color, p.Width);
            Start = startPoint;
            End = endPoint;

            MGraphic.DrawLine(p, startPoint, endPoint);
            //paintColor();
        }

        public override void fillColor(Color color)
        {            
        }

        public override void fillColor(Color x, Color y)
        {            
        }
    }
}
