using System.Drawing;

namespace SimplifiedProgrammingLanguage
{
    /// <summary>
    /// Class Polygon.
    /// Implements the <see cref="SimplifiedProgrammingLanguage.Shape" />
    /// </summary>
    /// <seealso cref="SimplifiedProgrammingLanguage.Shape" />
    class Polygon : Shape
    {
        /// <summary>
        /// The points
        /// </summary>
        float[] Points;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon"/> class.
        /// </summary>
        public Polygon() : base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="Points">The points.</param>
        public Polygon(float x, float y, float[] Points) : base(x, y)
        {
            this.Points = Points;
        }
        /// <summary>
        /// Sets the specified list.
        /// </summary>
        /// <param name="list">Pen Coordinates.</param>
        public override void Set(params float[] list)
        {
            base.Set(list[0], list[1]);
            Points = list;
        }
        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
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
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return base.ToString() + "  Points - " + string.Join(",", Points) + "]";
        }
    }
}