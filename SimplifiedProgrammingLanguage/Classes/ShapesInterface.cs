
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    //interface providing all methods necessary for when I create the shapes
    /// <summary>
    /// Interface ShapesInterface
    /// </summary>
    interface ShapesInterface
    {
        /// <summary>
        /// Sets the specified list.
        /// </summary>
        /// <param name="list">Pen Coordinates.</param>
        void Set(params float[] list);
        /// <summary>
        /// Draws the shape.
        /// </summary>
        /// <param name="g">Graphics class reference for drawing objects drawingCanvas.</param>
        void Draw(Graphics g);
       
    }
}
