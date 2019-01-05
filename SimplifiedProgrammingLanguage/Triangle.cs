using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
     class Triangle : Shape
    {
        float bottom, join;

        public Triangle() : base()
        {

        }

        public Triangle(float x, float y, float bottom, float join) : base(x, y)
        {
            this.bottom = bottom;
            this.join = join;
        }

        public override void Set(params float[] list)
        {
            base.Set(list[0], list[1]);
            bottom = list[2];
            join = list[3];
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            PointF[] points = 
            {
                new PointF(x, y), new PointF(x + bottom, y), new PointF(x, y + join)
            };
            g.DrawPolygon(p, points);
        }

        public override string ToString()
        {
            return base.ToString() + "  Bottom:" + bottom + "  Join:" + join;
        }
    }
}
