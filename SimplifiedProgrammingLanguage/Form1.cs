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

            String[] command = input.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for(int i =0; i < command.Length; i++)
            {
                String lineCommand = command[i];

                String[] lineCommandArray = lineCommand.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                if (lineCommandArray[0].Contains()

            }
            //split the string by the line in the array
            // loop through the array and then and split by the comma
            //then check each index position of the array and compare it to things like 'draw' and 'move'
            //then process the command

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
        }
    }
}

