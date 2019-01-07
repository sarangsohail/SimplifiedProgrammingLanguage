// ***********************************************************************
// Assembly         : SimplifiedProgrammingLanguage
// Author           : sarang
// Created          : 01-06-2019
//
// Last Modified By : sarang
using System.Drawing;

namespace SimplifiedProgrammingLanguage
{
    /// <summary>
    /// Class Shape.
    /// Implements the <see cref="SimplifiedProgrammingLanguage.ShapesInterface" />
    /// </summary>
    /// <seealso cref="SimplifiedProgrammingLanguage.ShapesInterface" />
    abstract class Shape : ShapesInterface
    {
        /// <summary>
        /// The x
        /// </summary>
        protected float x, y;
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        public Shape()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Shape(float x, float y)
        {
            //pen coordinates
            this.x = x;
            this.y = y;
        }

        //the three methods below are from the shapesInterface
        //here we are passing on the obligation to implement them to the derived classes by declaring them as abstract
        /// <summary>
        /// Draws the shape.
        /// </summary>
        /// <param name="g">Graphics class reference for drawing objects drawingCanvas.</param>
        public abstract void Draw(Graphics g); //any derrived class must implement this method
        //set is declared as virtual so it can be overridden by a more specific child version
        //but is here so it can be called by that child version to do the generic stuff
        //note the use of the param keyword to provide a variable parameter list to cope with some shapes having more setup information than others
        /// <summary>
        /// Sets the specified coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        public virtual void Set(params float[] coordinates)
        {
            x = coordinates[0];
            y = coordinates[1];
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return base.ToString() + "Points: X -  " + this.x + ", Y - " + this.y + " : ";
        }

    }
}

