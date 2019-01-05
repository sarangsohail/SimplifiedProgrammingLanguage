using System.Drawing;

namespace SimplifiedProgrammingLanguage
{
    class Polygon : Shape
    {
        float[] Points;

        public Polygon() : base()
        {

        }

        public Polygon(float x, float y, float[] Points) : base(x, y)
        {
            this.Points = Points;
        }

        public override void Set(params float[] list)
        {
            base.Set(list[0], list[1]);
            Points = list;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            PointF[] points = new PointF[Points.Length / 2];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointF(Points[i * 2], Points[(i * 2) + 1]);
            }
            g.DrawPolygon(pen, points);
        }

        public override string ToString()
        {
            return base.ToString() + "  Points - " + string.Join(",", Points) + "]";
        }
    }
}