using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    class ShapeGenerator
    {

        public ShapesInterface GetShape(string shapeCommands)
        {
            if (shapeCommands.Equals("circle"))
            {
                return new Circle();
            }
            else if (shapeCommands.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if (shapeCommands.Equals("triangle"))
            {
                return new Triangle();

            }
            else if (shapeCommands.Equals("poylogon"))
            {
                // todo - return new polygon
            }

            else
            {
                //if we get here then what has been passed in is unkown so throw an appropriate exception
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
            
        }

    }
}