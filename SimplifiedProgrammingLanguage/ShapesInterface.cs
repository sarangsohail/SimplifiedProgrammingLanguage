using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedProgrammingLanguage
{
    //interface providing all methods necessary for when I create the shapes
    interface ShapesInterface
    {
        void set(params float[] list);
        void draw(Graphics g);
       
    }
}
