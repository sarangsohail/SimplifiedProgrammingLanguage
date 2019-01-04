using System;
using System.Drawing;

namespace SimplifiedProgrammingLanguage
{
    class Circle : Shape
    {
        float radius;

        public Circle() : base()
        {

        }
        public Circle(Color colour, int x, int y, int radius) : base(x, y)
        {

            this.radius = radius; //the only thingthat is different from shape
        }


        public override void set(params float[] list)
        {
            //list[0] is x, list[1] is y, list[2] is radius
            base.set(list[0], list[1]);
            radius = list[2];
        }

        public override void draw(Graphics g)
        {

            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(Color.Black);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);

        }

       
        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString() + "  " + this.radius;
        }
    }
}