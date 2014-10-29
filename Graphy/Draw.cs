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
    class Draw
    {
        static public void MOV(Graphics graphics, Pen tmpen, int[,] pic, int dx, int dy, int top, int buttom)
        {
            Pen White = new Pen(Color.Blue);
            White.Width = tmpen.Width;
            int ww = (int)tmpen.Width;
            for (int xx = 0; xx < 567; xx++)
            {
                for (int yy = top; yy <= buttom; yy++)
                {
                    if (pic[xx, yy] != 0)
                    {
                        Rectangle rectangle = new Rectangle(xx, yy, ww, ww);
                        graphics.DrawRectangle(White, rectangle);
                        rectangle = new Rectangle(xx + dx, yy + dy, ww, ww);
                        graphics.DrawRectangle(tmpen, rectangle);
                    }
                }
            }
        }
        static public void drawLine(Graphics graphics, Pen tmpen, int startX, int startY, int endX, int endY,int style)
        {
            double dx = Math.Abs(startX - endX);
            double dy = Math.Abs(startY - endY);
            int x, ex = 0;
            int y, ey = 0;
            int step;
            double dd;
            if (startX - endX < 0)
                ex = 1;
            else if (startX - endX > 0)
                ex = -1;
            if (startY - endY < 0)
                ey = -1;
            else if (startY - endY > 0)
                ey = 1;
            int w = (int)tmpen.Width;
            switch(style)
            {
                case 1:
                    if (dx == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dy; y = y - ey,step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                        }
                        break;
                    }
                    if (dy == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dx; x=x+ex,step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                        }
                        break;
                    }
                    if (dy / dx <= 1)
                    {
                        dd = -dx;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dx; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            x = x + ex;
                            dd = dd + 2 * dy;
                            if (dd >= 0)
                            {
                                y = y - ey;
                                dd = dd - 2 * dx;
                            }
                        }
                    }
                    else
                    {
                        dd = -dy;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dy; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            y = y - ey;
                            dd = dd + 2 * dx;
                            if (dd >= 0)
                            {
                                x = x + ex;
                                dd = dd - 2 * dy;
                            }
                        }
                    }
                    break;
                case 2:
                    int pp=0;
                    if (dx == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dy; y = y - ey, step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp <= 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                        }
                        break;
                    }
                    if (dy == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dx; x = x + ex, step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp <= 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                        }
                        break;
                    }
                    if (dy / dx <= 1)
                    {
                        dd = -dx;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dx; step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp <= 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            x = x + ex;
                            dd = dd + 2 * dy;
                            if (dd >= 0)
                            {
                                y = y - ey;
                                dd = dd - 2 * dx;
                            }
                        }
                    }
                    else
                    {
                        dd = -dy;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dy; step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp <= 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            y = y - ey;
                            dd = dd + 2 * dx;
                            if (dd >= 0)
                            {
                                x = x + ex;
                                dd = dd - 2 * dy;
                            }
                        }
                    }
                    break;
                case 3:
                    pp = 0;
                    if (dx == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dy; y = y - ey, step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp == 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                        }
                        break;
                    }
                    if (dy == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dx; x = x + ex, step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp == 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                        }
                        break;
                    }
                    if (dy / dx <= 1)
                    {
                        dd = -dx;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dx; step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp == 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            x = x + ex;
                            dd = dd + 2 * dy;
                            if (dd >= 0)
                            {
                                y = y - ey;
                                dd = dd - 2 * dx;
                            }
                        }
                    }
                    else
                    {
                        dd = -dy;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dy; step++, pp = (pp + 1) % (10 * w))
                        {
                            if (pp == 5 * w)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            y = y - ey;
                            dd = dd + 2 * dx;
                            if (dd >= 0)
                            {
                                x = x + ex;
                                dd = dd - 2 * dy;
                            }
                        }
                    }
                    break;
                default:
                    if (dx == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dy; y = y - ey, step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                        }
                        break;
                    }
                    if (dy == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dx; x = x + ex, step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                        }
                        break;
                    }
                    if (dy / dx <= 1)
                    {
                        dd = -dx;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dx; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            x = x + ex;
                            dd = dd + 2 * dy;
                            if (dd >= 0)
                            {
                                y = y - ey;
                                dd = dd - 2 * dx;
                            }
                        }
                    }
                    else
                    {
                        dd = -dy;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dy; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            y = y - ey;
                            dd = dd + 2 * dx;
                            if (dd >= 0)
                            {
                                x = x + ex;
                                dd = dd - 2 * dy;
                            }
                        }
                    }
                    break;
            }
        }
        static public void drawLine(Graphics graphics, Pen tmpen, int startX, int startY, int endX, int endY, int style,int [,] pic)
        {
            double dx = Math.Abs(startX - endX);
            double dy = Math.Abs(startY - endY);
            int x, ex = 0;
            int y, ey = 0;
            int step;
            double dd;
            if (startX - endX < 0)
                ex = 1;
            else if (startX - endX > 0)
                ex = -1;
            if (startY - endY < 0)
                ey = -1;
            else if (startY - endY > 0)
                ey = 1;
            int w = (int)tmpen.Width;
            switch (style)
            {
                case 1:
                    if (dx == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dy; y = y - ey, step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            if (y != startY && y != endY)
                            {
                                pic[x, y] = (pic[x, y] + 1) % 2;
                            }
                            
                        }
                        break;
                    }
                    if (dy == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dx; x = x + ex, step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                        }
                        break;
                    }
                    if (dy / dx <= 1)
                    {
                        dd = -dx;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dx; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            x = x + ex;
                            dd = dd + 2 * dy;
                            if (dd >= 0)
                            {
                                y = y - ey;
                                if (y != startY && y != endY)
                                {
                                    pic[x, y] = (pic[x, y] + 1) % 2;
                                }
                                dd = dd - 2 * dx;
                            }
                        }
                    }
                    else
                    {
                        dd = -dy;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dy; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            y = y - ey;
                            if (y != startY && y != endY)
                            {
                                pic[x, y] = (pic[x, y] + 1) % 2;
                            }
                            dd = dd + 2 * dx;
                            if (dd >= 0)
                            {
                                x = x + ex;
                                dd = dd - 2 * dy;
                            }
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        static public void drawLine(Graphics graphics, Pen tmpen, int startX, int startY, int endX, int endY, int style, int[,] pic,bool  xx)
        {
            double dx = Math.Abs(startX - endX);
            double dy = Math.Abs(startY - endY);
            int x, ex = 0;
            int y, ey = 0;
            int step;
            double dd;
            Pen ttpen = new Pen(Color.Red);
            ttpen.Width = tmpen.Width;
            if (startX - endX < 0)
                ex = 1;
            else if (startX - endX > 0)
                ex = -1;
            if (startY - endY < 0)
                ey = -1;
            else if (startY - endY > 0)
                ey = 1;
            int w = (int)tmpen.Width;
            switch (style)
            {
                case 1:
                    if (dx == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dy; y = y - ey, step++)
                        {
                            if (pic[x, y] == 0)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(ttpen, rectangle);
                            }
                        }
                        break;
                    }
                    if (dy == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dx; x = x + ex, step++)
                        {
                            if (pic[x, y] == 0)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(ttpen, rectangle);
                            }
                        }
                        break;
                    }
                    if (dy / dx <= 1)
                    {
                        dd = -dx;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dx; step++)
                        {
                            if (pic[x, y] == 0)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(ttpen, rectangle);
                            }
                            x = x + ex;
                            dd = dd + 2 * dy;
                            if (dd >= 0)
                            {
                                y = y - ey;
                                dd = dd - 2 * dx;
                            }
                        }
                    }
                    else
                    {
                        dd = -dy;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dy; step++)
                        {
                            if (pic[x, y] == 0)
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(tmpen, rectangle);
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(x, y, w, w);
                                graphics.DrawRectangle(ttpen, rectangle);
                            }
                            y = y - ey;
                            dd = dd + 2 * dx;
                            if (dd >= 0)
                            {
                                x = x + ex;
                                dd = dd - 2 * dy;
                            }
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        static public void drawLineMov(Graphics graphics, Pen tmpen, int startX, int startY, int endX, int endY, int style, int[,] pic)
        {
            double dx = Math.Abs(startX - endX);
            double dy = Math.Abs(startY - endY);
            int x, ex = 0;
            int y, ey = 0;
            int step;
            double dd;
            if (startX - endX < 0)
                ex = 1;
            else if (startX - endX > 0)
                ex = -1;
            if (startY - endY < 0)
                ey = -1;
            else if (startY - endY > 0)
                ey = 1;
            int w = (int)tmpen.Width;
            switch (style)
            {
                case 1:
                    if (dx == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dy; y = y - ey, step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            pic[x, y] = 1;

                        }
                        break;
                    }
                    if (dy == 0)
                    {
                        for (x = startX, y = startY, step = 0; step < dx; x = x + ex, step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            pic[x, y] = 1;
                        }
                        break;
                    }
                    if (dy / dx <= 1)
                    {
                        dd = -dx;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dx; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            pic[x, y] = 1;
                            x = x + ex;
                            dd = dd + 2 * dy;
                            if (dd >= 0)
                            {
                                y = y - ey;
                                dd = dd - 2 * dx;
                            }
                        }
                    }
                    else
                    {
                        dd = -dy;
                        x = startX;
                        y = startY;
                        for (step = 0; step < dy; step++)
                        {
                            Rectangle rectangle = new Rectangle(x, y, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            y = y - ey;
                            pic[x, y] = 1;
                            dd = dd + 2 * dx;
                            if (dd >= 0)
                            {
                                x = x + ex;
                                dd = dd - 2 * dy;
                            }
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        static public void drawCircle(Graphics graphics,Pen tmpen,int startX, int startY, int endX, int endY,int style)
        {
            double rr = Math.Sqrt((endX - startX) * (endX - startX) + (endY - startY) * (endY - startY))/2;
            double ox = (startX + endX) / 2;
            double oy = (startY + endY) / 2;
            int x = 0;
            int y = (int)rr;
            int dir=0;
            double delta = 2 * (1 - rr);
            double delta1,delta2;
            Rectangle rectangle;
            int w = (int)tmpen.Width;
            int oo;
            switch (style)
            {
                case 1:
                    while (y >= 0)
                    {
                        rectangle = new Rectangle(x + (int)ox, -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        rectangle = new Rectangle(-1 * x + (int)ox, -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        rectangle = new Rectangle(x + (int)ox, -1 * -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        rectangle = new Rectangle(-1 * x + (int)ox, -1 * -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        if (delta < 0)
                        {
                            delta1 = 2 * (delta + y) - 1;
                            if (delta1 <= 0)
                                dir = 1;
                            else
                                dir = 2;
                        }
                        else if (delta > 0)
                        {
                            delta2 = 2 * (delta - x) - 1;
                            if (delta2 <= 0)
                                dir = 2;
                            else
                                dir = 3;
                        }
                        else
                            dir = 2;
                        switch (dir)
                        {
                            case 1:
                                x++;
                                delta += 2 * x + 1;
                                break;
                            case 2:
                                x++;
                                y--;
                                delta += 2 * (x - y + 1);
                                break;
                            case 3:
                                y--;
                                delta += (-2 * y + 1);
                                break;
                        }
                    }
                    break;
                case 2:
                    oo = -1;
                    while (y >= 0)
                    {
                        oo = (oo + 1) % (10 * w);
                        if (oo <= 5 * w)
                        {
                            rectangle = new Rectangle(x + (int)ox, -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            rectangle = new Rectangle(-1 * x + (int)ox, -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            rectangle = new Rectangle(x + (int)ox, -1 * -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            rectangle = new Rectangle(-1 * x + (int)ox, -1 * -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                        }
                        if (delta < 0)
                        {
                            delta1 = 2 * (delta + y) - 1;
                            if (delta1 <= 0)
                                dir = 1;
                            else
                                dir = 2;
                        }
                        else if (delta > 0)
                        {
                            delta2 = 2 * (delta - x) - 1;
                            if (delta2 <= 0)
                                dir = 2;
                            else
                                dir = 3;
                        }
                        else
                            dir = 2;
                        switch (dir)
                        {
                            case 1:
                                x++;
                                delta += 2 * x + 1;
                                break;
                            case 2:
                                x++;
                                y--;
                                delta += 2 * (x - y + 1);
                                break;
                            case 3:
                                y--;
                                delta += (-2 * y + 1);
                                break;
                        }
                    }
                    break;
                case 3:
                    oo = -1;
                    while (y >= 0)
                    {
                        oo = (oo + 1) % (10 * w);
                        if (oo == 5 * w)
                        {
                            rectangle = new Rectangle(x + (int)ox, -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            rectangle = new Rectangle(-1 * x + (int)ox, -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            rectangle = new Rectangle(x + (int)ox, -1 * -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                            rectangle = new Rectangle(-1 * x + (int)ox, -1 * -y + (int)oy, w, w);
                            graphics.DrawRectangle(tmpen, rectangle);
                        }
                        if (delta < 0)
                        {
                            delta1 = 2 * (delta + y) - 1;
                            if (delta1 <= 0)
                                dir = 1;
                            else
                                dir = 2;
                        }
                        else if (delta > 0)
                        {
                            delta2 = 2 * (delta - x) - 1;
                            if (delta2 <= 0)
                                dir = 2;
                            else
                                dir = 3;
                        }
                        else
                            dir = 2;
                        switch (dir)
                        {
                            case 1:
                                x++;
                                delta += 2 * x + 1;
                                break;
                            case 2:
                                x++;
                                y--;
                                delta += 2 * (x - y + 1);
                                break;
                            case 3:
                                y--;
                                delta += (-2 * y + 1);
                                break;
                        }
                    }
                    break;
                default:
                    while (y >= 0)
                    {
                        rectangle = new Rectangle(x + (int)ox, -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        rectangle = new Rectangle(-1 * x + (int)ox, -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        rectangle = new Rectangle(x + (int)ox, -1 * -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        rectangle = new Rectangle(-1 * x + (int)ox, -1 * -y + (int)oy, w, w);
                        graphics.DrawRectangle(tmpen, rectangle);
                        if (delta < 0)
                        {
                            delta1 = 2 * (delta + y) - 1;
                            if (delta1 <= 0)
                                dir = 1;
                            else
                                dir = 2;
                        }
                        else if (delta > 0)
                        {
                            delta2 = 2 * (delta - x) - 1;
                            if (delta2 <= 0)
                                dir = 2;
                            else
                                dir = 3;
                        }
                        else
                            dir = 2;
                        switch (dir)
                        {
                            case 1:
                                x++;
                                delta += 2 * x + 1;
                                break;
                            case 2:
                                x++;
                                y--;
                                delta += 2 * (x - y + 1);
                                break;
                            case 3:
                                y--;
                                delta += (-2 * y + 1);
                                break;
                        }
                    }
                    break;
            }
        }
         
    }
}
