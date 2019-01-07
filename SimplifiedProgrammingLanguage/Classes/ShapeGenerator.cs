using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    /// <summary>
    /// Class ShapeGenerator.
    /// </summary>
    class ShapeGenerator
    {

        /// <summary>
        /// Gets the shape.
        /// </summary>
        /// <param name="shapeCommand">Passed in to determine which class to call</param>
        /// <returns>Shape Class.</returns>
        public Shape GetShape(string shapeCommand)
        {
            if (shapeCommand.Equals("Circle"))
            {
                return new Circle();

            }else if (shapeCommand.Equals("Rectangle"))
            {
                return new Rectangle();

            }else if (shapeCommand.Equals("Triangle"))
            {
              return new Triangle();


            }else if (shapeCommand.Equals("Polygon"))
            {
                return new Polygon();
            }
            else{
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeCommand + " does not exist");
                throw argEx;
            }
        }
    }
}