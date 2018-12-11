using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedProgrammingLanguage
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        String[] commandArray;
         Graphics g = PictureBox1.



        private void commandInputter_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = commandInputter.Text;

            commandArray = input.Split(',');

            //rectangle array 
            string[] stringArray = {""};



            //circle Array
            ArrayList circleList = new ArrayList();
            int rectWidth;
            int rectHeight;
            foreach (String s in commandArray)
            {
                if (s.Contains("draw") && s.Contains("rectangle") == true)
                {
                    for (int i = 0; stringArray.Length(); i++) {




                    }

                    // find a way get this string command in the rectangle array

                }


            }

            
        }
    }
}
