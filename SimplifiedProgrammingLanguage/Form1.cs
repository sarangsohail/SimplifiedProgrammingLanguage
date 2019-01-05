using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedProgrammingLanguage
{
    public partial class Form1 : Form
    {

        ArrayList shapes = new ArrayList();
        private PointF Pen { get; set; }

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = drawingCanvas.CreateGraphics();
            Pen = new Point(0, 0);
            g.Clear(Color.White);
        }

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
                string[] singleLineCommand = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);



                if (singleLineCommand[0].Equals("moveTo"))
                {
                    try
                    {
                        string[] command = singleLineCommand[1].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        Pen = new PointF(float.Parse(command[0]), float.Parse(command[1]));

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                    if (singleLineCommand[0].Equals("Circle"))
                    {
                        try
                        {
                            string param = singleLineCommand[1];
                            Shape s = shapeGenerator.GetShape(singleLineCommand[0]);
                            s.Set(Pen.X, Pen.Y, float.Parse(param));
                            shapes.Add(s);

                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }

                    }

                    if (singleLineCommand[0].Equals("Rectangle"))
                    {

                        try
                        {
                            string shapeCommand = singleLineCommand[1];
                            string[] command = shapeCommand.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                            Shape shape = shapeGenerator.GetShape(singleLineCommand[0]);
                            shape.Set(Pen.X, Pen.Y, float.Parse(command[0]), float.Parse(command[1]));
                            shapes.Add(shape);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Oops, Shape error - ", error.Message);
                        }

                        if (singleLineCommand[0].Equals("Triangle"))
                        {

                            try
                            {
                                string shapeCommand = singleLineCommand[1];
                                string[] command = shapeCommand.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                                Shape shape = shapeGenerator.GetShape(singleLineCommand[0]);
                                shape.Set(Pen.X, Pen.Y, float.Parse(command[0]), float.Parse(command[1]));
                                shapes.Add(shape);
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show("Oops, Shape error - ", error.Message);
                            }

                            if (singleLineCommand[0].Equals("Polygon"))
                            {
                                try
                                {
                                    string shapeCommand = singleLineCommand[1];
                                    string[] command = shapeCommand.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                                    float[] points = new float[command.Length + 2];
                                    points[0] = Pen.X;
                                    points[1] = Pen.Y;

                                    for (int ii = 0; ii < points.Length; ii++)
                                    {
                                        points[i] = float.Parse(command[i - 2]);
                                    }
                                    //check if enough points are inserted in
                                    if (points.Length % 2 == 0 || points.Length >= 6)
                                    {
                                        Shape shape = shapeGenerator.GetShape(singleLineCommand[0]);
                                        shape.Set(points);
                                        shapes.Add(shape);
                                    }

                                }
                                catch (Exception error)
                                {
                                    MessageBox.Show("Oops, Shape error - ", error.Message);
                                }


                            }

                        }
                    }
                }
            }

            for (int j = 0; j < shapes.Count; j++)
            {
                Shape shape;
                shape = (Shape)shapes[j];
                if (shape != null)
                {
                    shape.Draw(g);
                    Console.WriteLine(shape.ToString());
                }
                else
                {
                    Console.WriteLine("invalid shape in array");
                }
            }
        }
    }
}


/*


* 
* 
* 
/* 
*/
