using Paint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint.ShapeUtils
{
    class PencilShape : Shape
    {
        private Pen mPen;
        private Graphics mGraphic;
        private Point start;
        private Point end;
        private List<Point> pointList;

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

        protected List<Point> PointList
        {
            get
            {
                return pointList;
            }

            set
            {
                pointList = value;
            }
        }

        public PencilShape()
        {
        }

        public PencilShape(List<Point> pList)
        {
            this.PointList = new List<Point>(pList);
        }
        public PencilShape(Point p)
        {
            this.PointList = new List<Point>();
            this.PointList.Add(p);
        }

        public PencilShape(Pen p, Point startP, Point endP)
        {
            this.Start = startP;
            this.End = endP;
            this.MPen = new Pen(p.Color, p.Width);
        }
        public override void draw()
        {
            if (PointList.Count > 1)
            {
                for (int i = 0; i < PointList.Count - 1; i++)
                {                   
                    this.MGraphic.DrawLine(MPen, PointList[i], PointList[i + 1]);
                }
            }
        }

        public override void draw(PaintEventArgs e)
        {
            if (PointList.Count > 1)
            {
                for (int i = 0; i < PointList.Count - 1; i++)
                {
                    this.MGraphic = e.Graphics;
                    this.MGraphic.DrawLine(MPen, PointList[i], PointList[i + 1]);
                }
            }
        }

        public bool addPoint(Point p)
        {
            if (p != null)
            { this.PointList.Add(p); }
            return true;
        }

        public override void draw(Pen p, PaintEventArgs e)
        {
            if (PointList.Count > 1)
            {
                for (int i = 0; i < PointList.Count - 1; i++)
                {
                    this.MGraphic = e.Graphics;
                    this.MPen = new Pen(p.Color, p.Width);
                    this.MGraphic.DrawLine(MPen, PointList[i], PointList[i + 1]);
                }
            }
        }

        public override void draw(Pen p, Point startPoint, Point endPoint, PaintEventArgs e)
        {
            this.MGraphic = e.Graphics;
            this.MPen = new Pen(p.Color, p.Width);
            this.addPoint(endPoint);       
        }
    }
}
