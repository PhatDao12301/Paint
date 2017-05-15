using MyPaint.ShapeUtils;
using Paint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen mPen = new Pen(Color.Black, (float)Thickness.normal);
        private Point start = new Point(0, 0);
        private Point end = new Point(0, 0);
        private Point current = new Point(0, 0);
        private int index = -1;
        private bool drawing;
        
        private List<Shape> shape = new List<Shape>();
        //private List<PointF> pointList = new List<PointF>();
        private Status state;
        private int thick;
        private Color lineColor;

        public enum Thickness
        {
            normal = 1,
            third = 3,
            fifth = 5,
            seventh = 7,
        }

        public enum Status
        {
            Pencil,
            Brush,
            Line,
            Ellipse,
            Rectangle,
            Square,
            Circle
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //shape.Add(new RectangleShape(start, end));
            WindowState = FormWindowState.Maximized;
            state = Status.Pencil;

            declareShapeClick();
            declareThicknessClick();
            declareShapeMouseHover();

            colorPickEdit1.Color = Color.Black;
            lineColor = colorPickEdit1.Color;          
        }

        private void declareShapeMouseHover()
        {
            btDrawPencil.MouseHover += showDetail;
            btDrawCircle.MouseHover += showDetail;
            btDrawLine.MouseHover += showDetail;
            btDrawEllipse.MouseHover += showDetail;
            btDrawRectangle.MouseHover += showDetail;
            btDrawSquare.MouseHover += showDetail;
        }
        private void declareShapeClick()
        {
            btDrawCircle.Click += shapeOptionClick;
            btDrawSquare.Click += shapeOptionClick;
            btDrawRectangle.Click += shapeOptionClick;
            btDrawEllipse.Click += shapeOptionClick;
            btDrawLine.Click += shapeOptionClick;
            btDrawPencil.Click += shapeOptionClick;
        }
        private void declareThicknessClick()
        {
            btThickness1.Click += chooseThickness;
            btThickness3.Click += chooseThickness;
            btThickness5.Click += chooseThickness;
            btThickness7.Click += chooseThickness;
        }

        // nhấn chuột pbCanvas
        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            current = e.Location;
            start = e.Location;
            drawing = true;
            lineColor = colorPickEdit1.Color;
            mPen.Color = lineColor;

            switch (state)
            {
                case Status.Pencil:
                    {
                        shape.Add(new PencilShape(current));
                        break;
                    }
                case Status.Line:
                    {
                        shape.Add(new LineShape(mPen, start, end));
                        break;
                    }
                case Status.Rectangle:
                    {
                        shape.Add(new RectangleShape(mPen, start, end));
                        break;
                    }
                case Status.Square:
                    {
                        shape.Add(new SquareShape(mPen, start, end));
                        break;
                    }
                case Status.Ellipse:
                    {
                        shape.Add(new EllipseShape(mPen, start, end));
                        break;
                    }
                case Status.Circle:
                    {
                        shape.Add(new CircleShape(mPen, start, end));
                        break;
                    }                
            }
        }

        // nhả chuột pbCanvas
        private void pbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            pbCanvas.Invalidate();
        }

        // di chuyển chuột trong pbCanvas
        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            current = e.Location;
            end = e.Location;

            if (drawing)
            {
                pbCanvas.Invalidate();
            }
        }

        // vẽ pbCanvas
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (shape.Count > 0)
            {
                for (int i = 0; i < shape.Count; i++)
                {
                    shape[i].draw(e);
                }                
                if (drawing)
                {
                    shape[shape.Count - 1].draw(mPen, start, end, e);
                    LinearGradientBrush linGrBrush = new LinearGradientBrush(
                        start, end, colorPickEdit1.Color, Color.Aqua);
                    //SolidBrush br = new SolidBrush(colorPickEdit1.Color);

                    Rectangle rc = new Rectangle(start.X, start.Y, 40, 100);
                    e.Graphics.FillRectangle(linGrBrush, rc);
                }
            }            
            
        }

        // envent click cho các shape
        private void shapeOptionClick(object sender, EventArgs e)
        {
            if (sender.Equals(btDrawPencil))
            {
                state = Status.Pencil;
                return;
            }
            if (sender.Equals(btDrawCircle))
            {
                state = Status.Circle;
                return;
            }
            if (sender.Equals(btDrawEllipse))
            {
                state = Status.Ellipse;
                return;
            }
            if (sender.Equals(btDrawRectangle))
            {
                state = Status.Rectangle;
                return;
            }
            if (sender.Equals(btDrawSquare))
            {
                state = Status.Square;
                return;
            }
            if (sender.Equals(btDrawLine))
            {
                state = Status.Line;
                return;
            }
        }

        // chọn độ dày của mPen
        private void chooseThickness(object sender, EventArgs e)
        {
            if (sender.Equals(btThickness1))
            {
                mPen = new Pen(Color.Black, 1);

                return;
            }
            if (sender.Equals(btThickness3))
            {
                mPen = new Pen(Color.Black, 3);
                return;
            }
            if (sender.Equals(btThickness5))
            {
                mPen = new Pen(Color.Black, 5);
                return;
            }
            if (sender.Equals(btThickness7))
            {
                mPen = new Pen(Color.Black, 7);
                return;
            }
        }

        private void showDetail(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            if (sender.Equals(btDrawRectangle))
            {
                ToolTip1.SetToolTip(btDrawRectangle, "Rectangle");
                return;
            }
            if (sender.Equals(btDrawSquare))
            {
                ToolTip1.SetToolTip(btDrawSquare, "Square");
                return;
            }
            if (sender.Equals(btDrawEllipse))
            {
                ToolTip1.SetToolTip(btDrawEllipse, "Ellipse");
                return;
            }
            if (sender.Equals(btDrawCircle))
            {
                ToolTip1.SetToolTip(btDrawCircle, "Circle");
                return;
            }
            if (sender.Equals(btDrawLine))
            {
                ToolTip1.SetToolTip(btDrawLine, "Line");
                return;
            }
            if (sender.Equals(btDrawPencil))
            {
                ToolTip1.SetToolTip(btDrawLine, "Pencil");
                return;
            }
        }
    }
}
