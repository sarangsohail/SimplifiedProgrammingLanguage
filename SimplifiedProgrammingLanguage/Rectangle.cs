using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    class Rectangle : Shape
    {

        float width, height;

        public Rectangle() : base()
        {

        }

        public Rectangle(float x, float y, float Width, float Height) : base(x, y)
        {
            this.width = Width;
            this.height = Height;
        }

        public override void Set(params float[] list)
        {
            base.Set(list[0], list[1]);
            width = list[2];
            height = list[3];
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, x, y, width, height);
        }

        public override string ToString()
        {
            return base.ToString() + "  Width:" + width + "  Height:" + height;
        }
    }
}
