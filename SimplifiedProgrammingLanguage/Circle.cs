using System;
using System.Drawing;

namespace SimplifiedProgrammingLanguage
{
    internal class Circle : ShapesInterface
    {

        int radius;

        public double calculateArea()
        {
            return Math.PI * (radius ^ 2);
        }

        public double calculatePerimeter()
        {
            return 2 * Math.PI*radius;
        }   

        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillEllipse(b, x, y, radius * 2, radius * 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);
        }

        public void GetShape()
        {
            throw new System.NotImplementedException();
        }

        public void set(Color c, params int[] list)
        {
            throw new System.NotImplementedException();
        }
    }
}