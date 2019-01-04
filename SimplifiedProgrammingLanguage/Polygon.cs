using System.Drawing;

namespace SimplifiedProgrammingLanguage
{
    public class Polygon : Shape
    {
        float[] Points;

        public Polygon() : base()
        {

        }

        public Polygon(float x, float y, float[] Points) : base(x, y)
        {
            this.Points = Points;
        }

        public override void set(params float[] list)
        {
            base.set(list[0], list[1]);
            Points = list;
        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Yellow, 2);
            PointF[] pts = new PointF[Points.Length / 2];
            for (int i = 0; i < pts.Length; i++)
            {
                pts[i] = new PointF(Points[i * 2], Points[(i * 2) + 1]);
            }
            g.DrawPolygon(p, pts);
        }

        public override string ToString()
        {
            return base.ToString() + "  Points - " + string.Join(",", Points) + "]";
        }
    }
}