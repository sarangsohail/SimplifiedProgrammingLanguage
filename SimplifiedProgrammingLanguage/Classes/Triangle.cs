using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    /// <summary>
    /// Class Triangle.
    /// Implements Shape" />
    /// </summary>
    /// <seealso cref="SimplifiedProgrammingLanguage.Shape" />
    class Triangle : Shape
    {
        /// <summary>
        /// The bottom
        /// </summary>
        float bottom, join;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        public Triangle() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="bottom">The bottom.</param>
        /// <param name="join">The join.</param>
        public Triangle(float x, float y, float bottom, float join) : base(x, y)
        {
            this.bottom = bottom;
            this.join = join;
        }

        /// <summary>
        /// Sets the specified list.
        /// </summary>
        /// <param name="list">Pen Coordinates.</param>
        public override void Set(params float[] list)
        {
            base.Set(list[0], list[1]);
            bottom = list[2];
            join = list[3];
        }

        /// <summary>
        /// Draws the shape.
        /// </summary>
        /// <param name="g">Graphics class reference for drawing objects drawingCanvas.</param>
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            PointF[] points = 
            {
                new PointF(x, y), new PointF(x + bottom, y), new PointF(x, y + join)
            };
            g.DrawPolygon(pen, points);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return base.ToString() + "  Bottom:" + bottom + "  Join:" + join;
        }
    }
}
