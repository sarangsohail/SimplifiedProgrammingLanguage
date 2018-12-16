using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    class ShapeGenerator {

        public ShapesInterface GetShape(params string[] shapeCommands)
        {
            if (shapeCommands.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeCommands.Equals("RECTANGLE"))
            {
               // return new Rectangle();

            }
            else if (shapeCommands.Equals("SQUARE"))
            {
               // return new Square();
            }
            else
            {
                //if we get here then what has been passed in is inkown so throw an appropriate exception
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
        }

    }