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

        }

        String[] commandArray;

        int penX = 0;
        int penY = 0;
        Boolean penStatus;

        private void commandInputter_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = commandInputter.Text;

            commandArray = input.Split(',');

            //rectangle array 
            string[] stringArray = { "" };



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

                }
                else if (s.Equals("pendown"))
                {
                    penStatus = false;
                    //add some colour in the back to let the user know that the pen is down

                }

                // add a switch case or another condition checker to verify the pen status and draw the shape

                if (s.Contains("draw") && s.Contains("rectangle") == true)
                {// find a way get this string command in the rectangle array}

                }


            }
        }
    }
}

