using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    /// <summary>
    /// Class Rectangle.
    /// Implements the <see cref="SimplifiedProgrammingLanguage.Shape" />
    /// </summary>
    /// <seealso cref="SimplifiedProgrammingLanguage.Shape" />
    class Rectangle : Shape
    {

        /// <summary>
        /// The width
        /// </summary>
        float width, height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        public Rectangle(float x, float y, float Width, float Height) : base(x, y)
        {
            this.width = Width;
            this.height = Height;
        }

        /// <summary>
        /// Sets the specified list.
        /// </summary>
        /// <param name="list">Pen Coordinates.</param>
        public override void Set(params float[] list)
        {
            base.Set(list[0], list[1]);
            width = list[2];
            height = list[3];
        }

        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, x, y, width, height);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return base.ToString() + "  Width:" + width + "  Height:" + height;
        }
    }
}
