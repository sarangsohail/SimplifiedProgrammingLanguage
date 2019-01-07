using System;
using System.Drawing;

namespace SimplifiedProgrammingLanguage
{
    /// <summary>
    /// Class Circle.
    /// Implements the <see cref="SimplifiedProgrammingLanguage.Shape" />
    /// </summary>
    /// <seealso cref="SimplifiedProgrammingLanguage.Shape" />
    class Circle : Shape
    {
        /// <summary>
        /// The radius
        /// </summary>
        float radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle() : base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="radius">The radius.</param>
        public Circle(Color colour, int x, int y, int radius) : base(x, y)
        {
            this.radius = radius; //Different from Shape
        }

        /// <summary>
        /// Sets the specified list.
        /// </summary>
        /// <param name="list">Pen Coordinates.</param>
        public override void Set(params float[] list)
        {
            //list[0] is x, list[1] is y, list[2] is radius
            base.Set(list[0], list[1]);
            radius = list[2];
        }

        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The graphics reference.</param>
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            SolidBrush b = new SolidBrush(Color.Black);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);

        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString() + "  " + this.radius;
        }
    }
}