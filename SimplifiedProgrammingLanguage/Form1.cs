using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedProgrammingLanguage
{
    public partial class Form1 : Form
    {

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = drawingCanvas.CreateGraphics();
            g.Clear(Color.White);
        }

        int penX = 0;
        int penY = 0;
        Boolean penStatus = false;

        private void commandInputter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShapeGenerator shapeGenerator = new ShapeGenerator();

            String input = commandInputter.Text;

            string[] commands = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < commands.Length; i++)
            {
                string line = commands[i];
                string[] singleCommand = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if(singleCommand[0].Equals("moveTo"))
                {




                }







            }

            //split the string by the line in the array - done
            //split it by a comma -  done
            //then check each index position of the array and compare it to things like 'draw' and 'move'
            //then process the command

            commandArray = input.Split(',');

          for (int i = 0; i < commandArray.Length; i++)
            {
                
                if(string.Equals(commandArray[i], "penup", StringComparison.OrdinalIgnoreCase))
                {
                    penStatus = false;
                }

                if (string.Equals(commandArray[i], "pendown", StringComparison.OrdinalIgnoreCase))
                {
                    penStatus = true;
                }


                if (string.Equals(commandArray[i], "moveto", StringComparison.OrdinalIgnoreCase))
                {
                    i++;
                    penX = int.Parse(commandArray[i]);
                    i++;
                    penY = int.Parse(commandArray[i]);

                }

                    if (commandArray[i].Equals("rectangle"))
                    {
                        i++;
                        int recWidth = int.Parse(commandArray[i]);
                        i++;
                        int recLength = int.Parse(commandArray[i]);

                    Shape s = (Shape) shapeGenerator.GetShape("rectangle");
                    s.set(Color.Black, recX, recY, )
                    }

            }
            
            
            
            
            /*
            //rectangle array 
            string[] stringArray = { "" };



           
             * -------------this is redundant - it think
            //circle Array
            ArrayList circleList = new ArrayList();
            int rectWidth;
            int rectHeight;
            foreach (String s in commandArray)
            {
                if (s.Equals("penup"))
                {
                    penStatus = true;
                    //add some colour in the back to let the user know that the pen is up

                    if(s.Equals("draw") && s.Contains("rectangle"))
                    {


                    }
                }
                else if (s.Equals("pendown"))
                {
                    penStatus = false;
                    //add some colour in the back to let the user know that the pen is down

                }

                // add a switch case or another condition checker to verify the pen status and draw the shape


            }

    */
        }
    }
}

//maybe add a undo feature???