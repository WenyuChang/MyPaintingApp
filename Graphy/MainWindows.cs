using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;

namespace Graphy
{
    public partial class MainWindows : Form
    {
        int[,] pic;
        int level;
        public int preX;
        public int preY;
        public int lastX;
        public int lastY;
        public int StartX;
        public int StartY;
        public int TopY;
        public int ButtomY;
        public Color newColor;
        public int type;
        public int locX;
        public int locY;
        public int movX;
        public int movY;
        public bool ifline;
        public bool ifrectangle;
        public bool iffilledrectangle;
        public bool ifcircle;
        public bool ifFilledCircle;
        public bool ifEraser;
        public bool ifCurve;
        public bool ifPolygon;
        public bool ifHollow;
        public bool ifFilledEllipse;
        public bool ifFilledPolygon;
        public bool ifmove;
        public bool ifreadymove;
        public bool ifup;
        public bool ifcut;
        public bool ifreadycut;
        public Pen myPen;
        public MainWindows()
        {
            InitializeComponent();
            pic = new int[567, 427];
            ifline = false;
            ifrectangle = false;
            iffilledrectangle = false;
            ifcircle = false;
            ifEraser = false;
            ifCurve = false;
            ifPolygon = false;
            ifHollow = false;
            ifFilledEllipse = false;
            ifFilledPolygon = false; 
            ifFilledCircle = false;
            ifmove = false;
            ifreadymove = false;
            ifcut = false;
            ifreadycut = false;
            TopY = 0;
            ButtomY = 0;
            ifup = true;
            level = 0;
            newColor = this.Black.BackColor;
        }

        public void DrawPoint()
        {
            int x = (int)myPen.Width;
            Graphics graphics = Drawing.CreateGraphics();
            Rectangle rectangle = new Rectangle(locX, locY, x, x);
            graphics.DrawRectangle(myPen, rectangle);
        }

        public void line()
        {
            ifline = true;
            ifup = false;
            int x=int.Parse(widthnum.Text);
            myPen.Width = x;
        }

        public void Rectangle()
        {
            ifrectangle = true;
            ifup = false;
        }

        public void FilledRectangle()
        {
            iffilledrectangle = true;
            ifup = false;

        }

        public void Circle()
        {
            ifcircle = true;
            ifup = false;
        }

        public void FilledCircle()
        {
            ifFilledCircle = true;
            ifup = false;
        }

        public void Eraser(MouseEventArgs e)
        {
            ifEraser = true;
            ifup = false;
            preX = e.X;
            preY = e.Y;
        }

        public void Curve(MouseEventArgs e)
        {
            ifCurve = true;
            ifup = false;
            preX = e.X;
            preY = e.Y;
        }

        public void Polygon(MouseEventArgs e)
        {
            if (!ifPolygon)
            {
                ifPolygon = true;
                ifup = false;
                preX = e.X;
                preY = e.Y;
                StartX = e.X;
                StartY = e.Y;
            }
        }

        public void FilledPolygon(MouseEventArgs e)
        {
            if (!ifFilledPolygon)
            {
                for (int ii = 0; ii < 567; ii++)
                {
                    for (int jj = 0; jj < 427; jj++)
                        pic[ii, jj] = 0;
                }
                ifFilledPolygon = true;
                ifup = false;
                preX = e.X;
                preY = e.Y;
                lastX = e.X;
                lastY = e.Y;
                StartX = e.X;
                StartY = e.Y;
                TopY = e.Y;
                ButtomY = e.Y;
            }
        }

        public void TwoDmove(MouseEventArgs e)
        {
            if (!ifmove)
            {
                for (int ii = 0; ii < 567; ii++)
                {
                    for (int jj = 0; jj < 427; jj++)
                        pic[ii, jj] = 0;
                }
                ifmove = true;
                preX = e.X;
                preY = e.Y;
                StartX = e.X;
                StartY = e.Y;
            }
            if (ifreadymove)
            {
                StartX = e.X;
                StartY = e.Y;
            }
        }

        public void cut(MouseEventArgs e)
        {
            ifcut = true;
            if (!ifreadycut)
            {
                if (!ifFilledPolygon)
                {
                    for (int ii = 0; ii < 567; ii++)
                    {
                        for (int jj = 0; jj < 427; jj++)
                            pic[ii, jj] = 0;
                    }
                    ifFilledPolygon = true;
                    ifup = false;
                    preX = e.X;
                    preY = e.Y;
                    lastX = e.X;
                    lastY = e.Y;
                    StartX = e.X;
                    StartY = e.Y;
                    TopY = e.Y;
                    ButtomY = e.Y;
                }
            }
            else
            {
                ifline = true;
            }
            
        }

        public void FilledEllipse()
        {
            ifFilledEllipse = true;
            ifup = false;
        }

        public void HollowEllipse()
        {
            ifHollow = true;
            ifup = false;
        }
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Black_Click(object sender, EventArgs e)
        {
            newColor = this.Black.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "Black";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            newColor = this.White.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "White";
        }

        private void White_Click(object sender, EventArgs e)
        {
            newColor = this.White.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "White";
        }

        private void Red_Click(object sender, EventArgs e)
        {
            newColor = this.Red.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "Red";
        }

        private void blue_Click(object sender, EventArgs e)
        {
            newColor = this.blue.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "Blue";
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            newColor = this.Yellow.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "Yellow";
        }

        private void LawnGreen_Click(object sender, EventArgs e)
        {
            newColor = this.LawnGreen.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "Green";
        }

        private void Cyan_Click(object sender, EventArgs e)
        {
            newColor = this.Cyan.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "Cyan";
        }

        private void Magenta_Click(object sender, EventArgs e)
        {
            newColor = this.Magenta.BackColor;
            btnColor.BackColor = newColor;
            ColorS.Text = "Magenta";
        }

        private void AddLine_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Line";
            type = 2;
            
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Point";
            type = 1;
        }

        private void AddHollowRectangle_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Rectangle";
            type = 3;
        }

        private void AddFilledRectangle_Click(object sender, EventArgs e)
        {
            TypeS.Text = "FilledRectangle";
            type = 4;
        }

        private void AddCircle_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Circle";
            type = 7;
        }

        private void AddHollowEllipse_Click(object sender, EventArgs e)
        {
            TypeS.Text = "HollowEllipse";
            type = 5;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Eraser";
            type = 10;
        }

        private void AddFilledEllipse_Click(object sender, EventArgs e)
        {
            TypeS.Text = "FilledEllipse";
            type = 6;
        }

        private void AddFillCircle_Click(object sender, EventArgs e)
        {
            TypeS.Text = "FilledCircle";
            type = 8;
        }

        private void AddPath_Click(object sender, EventArgs e)
        {

        }

        private void AddPolygon_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Polygon";
            type = 13;
        }

        private void AddFilledPolygon_Click(object sender, EventArgs e)
        {
            TypeS.Text = "FilledPolygon";
            type = 12;
        }

        private void AddCurve_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Curve";
            type = 14;
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            TypeS.Text = "2D_Move";
            type = 9;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            TypeS.Text = "Cut";
            type = 11;
        }

        private void Drawing_MouseMove(object sender, MouseEventArgs e)
        {
            movX = e.X;
            movY = e.Y;
            Position.Text = movX.ToString() + " , " + movY.ToString();
            if (ifEraser)
            {
                
                Graphics graphics = Drawing.CreateGraphics();
                Pen tmpen = new Pen(this.White.BackColor);
                int x = int.Parse(widthnum.Text);
                tmpen.Width = x;
                //graphics.DrawLine(tmpen, preX, preY, e.X, e.Y);
                Draw.drawLine(graphics, tmpen, preX, preY, e.X, e.Y, int.Parse(Stylenum.Text));
                preX = e.X;
                preY = e.Y;

            }
            if (ifCurve)
            {
                Graphics graphics = Drawing.CreateGraphics();
                int x = (int)myPen.Width;
                //graphics.DrawLine(myPen, preX, preY, e.X, e.Y);
                Draw.drawLine(graphics, myPen, preX, preY, e.X, e.Y, int.Parse(Stylenum.Text));
                preX = e.X;
                preY = e.Y;
            }
        }

        private void Drawing_MouseLeave(object sender, EventArgs e)
        {
            Position.Text = "";
        }

        private void Drawing_MouseDown(object sender, MouseEventArgs e)
        {
            locX = e.X;
            locY = e.Y;
            myPen = new Pen(newColor);
            int x = int.Parse(widthnum.Text);
            myPen.Width = x;
            switch (type)
            {
                case 1:
                    DrawPoint();
                    break;
                case 2:
                    line();
                    break;
                case 3:
                    Rectangle();
                    break;
                case 4:
                    FilledRectangle();
                    break;
                case 5:
                    HollowEllipse();
                    break;
                case 6:
                    FilledEllipse();
                    break;
                case 7:
                    Circle();
                    break;
                case 8:
                    FilledCircle();
                    break;
                case 9:
                    TwoDmove(e);
                    break;
                case 10:
                    Eraser(e);
                    break;
                case 11:
                    cut(e);
                    break;
                case 12:
                    FilledPolygon(e);
                    break;
                case 13:
                    Polygon(e);
                    break;
                case 14:
                    Curve(e);
                    break;
            }
        }

        private void Drawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (ifline)
            {
                Graphics graphics = Drawing.CreateGraphics();
                //graphics.DrawLine(myPen, locX, locY, e.X, e.Y);
                ifline = false;
                ifup = true;
                if(!ifcut)
                    Draw.drawLine(graphics, myPen, locX, locY, e.X, e.Y, int.Parse(Stylenum.Text));
                else
                {
                    ifcut = false;
                    ifreadycut = false;
                    Draw.drawLine(graphics, myPen, locX, locY, e.X, e.Y, int.Parse(Stylenum.Text),pic,true);
                }
            }
            if (ifrectangle)
            {
                
                Graphics graphics = Drawing.CreateGraphics();
                //graphics.DrawLine(myPen, locX, locY, locX, e.Y);
                //graphics.DrawLine(myPen, locX, locY, e.X, locY);
                //graphics.DrawLine(myPen, e.X, locY, e.X, e.Y);
                //graphics.DrawLine(myPen, locX, e.Y, e.X, e.Y);
                Draw.drawLine(graphics, myPen, locX, locY, locX, e.Y, int.Parse(Stylenum.Text));
                Draw.drawLine(graphics, myPen, locX, locY, e.X, locY, int.Parse(Stylenum.Text));
                Draw.drawLine(graphics, myPen, e.X, locY, e.X, e.Y, int.Parse(Stylenum.Text));
                Draw.drawLine(graphics, myPen, locX, e.Y, e.X, e.Y, int.Parse(Stylenum.Text));
                ifrectangle = false;
                ifup = true;
            }
            if (ifHollow)
            {
                ifHollow = false;
                ifup = true;
                Graphics graphics = Drawing.CreateGraphics();
                //Rectangle rectangle = new Rectangle(locX, locY, e.X, e.Y);
                graphics.DrawEllipse(myPen, locX, locY, e.X - locX, e.Y - locY);
                
            }
            if (ifFilledEllipse)
            {
                ifFilledEllipse = false;
                ifup = true;
                Graphics graphics = Drawing.CreateGraphics();
                graphics.FillEllipse(new SolidBrush(myPen.Color), locX, locY, e.X - locX, e.Y - locY);
            }
            if (iffilledrectangle)
            {
                int ii=locY;
                iffilledrectangle=false;
                ifup=true;
                Graphics graphics = Drawing.CreateGraphics();
                if (locY <= e.Y)
                {
                    for (ii = locY; ii < e.Y; ii++)
                    {
                        //graphics.DrawLine(myPen, locX, ii, e.X, ii);
                        Draw.drawLine(graphics, myPen, locX, ii, e.X, ii, 1);
                    }
                }
                else
                {
                    for (ii = e.Y; ii < locY; ii++)
                    {
                        //graphics.DrawLine(myPen, locX, ii, e.X, ii);
                        Draw.drawLine(graphics, myPen, locX, ii, e.X, ii, 1);
                    }
                }
            }
            if (ifcircle)
            {
                ifcircle = false;
                ifup = true;
                Graphics graphics = Drawing.CreateGraphics();
                //Rectangle rectangle = new Rectangle(locX, locY, e.X, e.Y);
                //graphics.DrawEllipse(myPen, locX, locY, e.X - locX, e.Y - locY);
                Draw.drawCircle(graphics, myPen, locX, locY, e.X, e.Y, int.Parse(Stylenum.Text));
            }

            if (ifFilledCircle)
            {
                ifFilledCircle = false;
                ifup = true;
                ifFilledEllipse = false;
                ifup = true;
                Graphics graphics = Drawing.CreateGraphics();
                if (e.X - locX < e.Y - locY)
                    graphics.FillEllipse(new SolidBrush(myPen.Color), locX, locY, e.X - locX, e.X - locX);
                else
                    graphics.FillEllipse(new SolidBrush(myPen.Color), locX, locY, e.Y - locY, e.Y - locY);
            }

            if (ifEraser)
            {
                ifEraser = false;
                ifup = true;
            }

            if (ifCurve)
            {
                ifCurve = false;
                ifup = true;
            }

            if (ifmove)
            {
                if (e.Y < TopY)
                    TopY = e.Y;
                if (e.Y > ButtomY)
                    ButtomY = e.Y;
                Graphics graphics = Drawing.CreateGraphics();
                if (!ifreadymove)
                {
                    if ((e.X - StartX) * (e.X - StartX) + (e.Y - StartY) * (e.Y - StartY) > 5)
                    {
                        //graphics.DrawLine(myPen, preX, preY, e.X, e.Y);
                        Draw.drawLineMov(graphics, myPen, preX, preY, e.X, e.Y, int.Parse(Stylenum.Text), pic);
                        preX = e.X;
                        preY = e.Y;
                    }
                    else
                    {
                        //graphics.DrawLine(myPen, preX, preY, StartX, StartY);
                        Draw.drawLineMov(graphics, myPen, preX, preY, StartX, StartY, int.Parse(Stylenum.Text), pic);
                        ifPolygon = false;
                        ifreadymove = true;
                    }
                }
                else
                {
                    int dx = e.X - StartX;
                    int dy = e.Y - StartY;
                    Pen pp=new Pen(Color.Red);
                    pp.Width=1;
                    Draw.drawLine(graphics, pp, StartX, StartY, e.X, e.Y, 1);
                    Rectangle rectangle = new Rectangle(e.X, e.Y, 1, 1);
                    pp.Width = 15;
                    graphics.DrawRectangle(pp, rectangle);
                    Draw.MOV(graphics, myPen, pic, dx, dy, TopY, ButtomY);
                    ifmove = false;
                    ifreadymove = false;
                }
            }

            if (ifPolygon)
            {
                Graphics graphics = Drawing.CreateGraphics();
                if ((e.X - StartX) * (e.X - StartX) + (e.Y - StartY) * (e.Y - StartY) > 5)
                {
                    //graphics.DrawLine(myPen, preX, preY, e.X, e.Y);
                    Draw.drawLine(graphics, myPen, preX, preY, e.X, e.Y, int.Parse(Stylenum.Text));
                    preX = e.X;
                    preY = e.Y;
                }
                else
                {
                    //graphics.DrawLine(myPen, preX, preY, StartX, StartY);
                    Draw.drawLine(graphics, myPen, preX, preY, StartX, StartY, int.Parse(Stylenum.Text));
                    ifPolygon = false;
                    ifup = true;
                }
            }
            if (ifFilledPolygon)
            {
                if (e.Y < TopY)
                    TopY = e.Y;
                if (e.Y > ButtomY)
                    ButtomY = e.Y;
                Graphics graphics = Drawing.CreateGraphics();
                if ((e.X - StartX) * (e.X - StartX) + (e.Y - StartY) * (e.Y - StartY) > 5)
                {
                    //graphics.DrawLine(myPen, preX, preY, e.X, e.Y);
                    Draw.drawLine(graphics, myPen, preX, preY, e.X, e.Y, 1, pic);
                    if (preX != StartX && preY != StartY)
                    {
                        if ((lastY > preY && e.Y > preY) || (lastY < preY && e.Y < preY))
                        {
                            pic[preX, preY] = (pic[preX, preY] + 0) % 2;
                        }
                        else
                        {
                            pic[preX, preY] = (pic[preX, preY] + 1) % 2;
                        }
                    }
                    lastX = preX;
                    lastY = preY;
                    preX = e.X;
                    preY = e.Y;
                }
                else
                {
                    //graphics.DrawLine(myPen, preX, preY, StartX, StartY);
                    Draw.drawLine(graphics, myPen, preX, preY, StartX, StartY, 1, pic);
                    ifFilledPolygon = false;
                    ifup = true;
                    if (ifcut)
                        ifreadycut = true;
                    if ((lastY > preY && e.Y > preY) || (lastY < preY && e.Y < preY))
                    {
                        pic[preX, preY] = (pic[preX, preY] + 0) % 2;
                    }
                    else
                    {
                        pic[preX, preY] = (pic[preX, preY] + 1) % 2;
                    }
                    if (!ifcut)
                    {
                        for (int yyy = TopY; yyy <= ButtomY; yyy++)
                        {
                            int tmp = 0;
                            Pen whitepen = new Pen(this.White.BackColor);
                            for (int xxx = 29; xxx < 567; xxx++)
                            {
                                tmp = (tmp + pic[xxx, yyy]) % 2;
                                if (tmp == 1)
                                {
                                    if (pic[xxx, yyy] == 0)
                                    {
                                        Rectangle rectangle = new Rectangle(xxx, yyy, 1, 1);
                                        graphics.DrawRectangle(myPen, rectangle);
                                    }
                                }
                                if (tmp == 0)
                                {
                                    /*if (pic[xxx, yyy] == 0)
                                    {
                                        Rectangle rectangle = new Rectangle(xxx, yyy, 1, 1);
                                        graphics.DrawRectangle(whitepen, rectangle);
                                    }*/
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int yyy = TopY; yyy <= ButtomY; yyy++)
                        {
                            int tmp = 0;
                            Pen whitepen = new Pen(this.White.BackColor);
                            for (int xxx = 29; xxx < 567; xxx++)
                            {
                                tmp = (tmp + pic[xxx, yyy]) % 2;
                                if (tmp == 1)
                                {
                                    if (pic[xxx, yyy] == 0)
                                    {
                                        pic[xxx, yyy] = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void Drawing_Click(object sender, EventArgs e)
        {

        }

        private void MainWindows_Load(object sender, EventArgs e)
        {

        }

    }
}
