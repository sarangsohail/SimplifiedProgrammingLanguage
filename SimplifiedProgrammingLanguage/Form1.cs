using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace SimplifiedProgrammingLanguage
{
    public partial class Form1 : Form
    {

        ArrayList shapesArray = new ArrayList();
        private PointF penLocation { get; set; }

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = drawingCanvas.CreateGraphics();
            penLocation = new Point(0, 0);
            g.Clear(Color.White);
        }

        Boolean penStatus = false;

        private void commandInputter_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShapeGenerator shapeGenerator = new ShapeGenerator();

            string input = commandInputter.Text;

            string[] commands = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < commands.Length; i++)
            {
                string line = commands[i];
                string[] singleLineCommand = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);


                if (singleLineCommand[0].Equals("moveTo"))
                {
                    try
                    {
                        string[] param = singleLineCommand[1].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        penLocation = new PointF(float.Parse(param[0]), float.Parse(param[1]));

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                }

                if (singleLineCommand[0].Equals("Circle"))
                {
                    try
                    {
                        string command = singleLineCommand[1];
                        Shape shape = shapeGenerator.GetShape(singleLineCommand[0]);
                        shape.Set(penLocation.X, penLocation.Y, float.Parse(command));
                        shapesArray.Add(shape);
                        shape.Draw(g);

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                }

                if (singleLineCommand[0].Equals("Triangle"))
                {
                    try
                    {
                        string param = singleLineCommand[1];
                        string[] para = param.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        Shape shapes = shapeGenerator.GetShape(singleLineCommand[0]);
                        shapes.Set(penLocation.X, penLocation.Y, float.Parse(para[0]), float.Parse(para[1]));
                        shapesArray.Add(shapes);
                        shapes.Draw(g);
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
                        shape.Set(penLocation.X, penLocation.Y, float.Parse(command[0]), float.Parse(command[1]));
                        shapesArray.Add(shape);
                        shape.Draw(g);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Oops, Shape error - ", error.Message);
                    }
                }


                if (singleLineCommand[0].Equals("Polygon"))
                {
                    try
                    {
                        string command = singleLineCommand[1];
                        string[] para = command.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        float[] Points = new float[para.Length + 2];
                        Points[0] = penLocation.X;
                        Points[1] = penLocation.Y;
                        for (int j = 2; j < Points.Length; j++)
                        {
                            Points[j] = float.Parse(para[j - 2]);
                        }

                        Shape shape = shapeGenerator.GetShape(singleLineCommand[0]);
                        shape.Set(Points);
                        shapesArray.Add(shape);
                        shape.Draw(g);

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                }

                if (singleLineCommand[0].Equals("Repeat"))
                {
                    int quantity = int.Parse(singleLineCommand[1]);
                    if (singleLineCommand[2].Equals("Circle"))
                    {
                        float radius = 0;
                        for (int ii = 0; ii < quantity; ii++)
                        {
                            Shape shape = shapeGenerator.GetShape(singleLineCommand[2]);
                            //repeat quantity is * by the radius 
                            radius += float.Parse(singleLineCommand[4].Replace("+", ""));
                            shape.Set(penLocation.X - radius, penLocation.Y - radius, radius);
                            shapesArray.Add(shape);
                        }
                    }
                }
            
                for (int j = 0; j < shapesArray.Count; j++)
                {
                    Shape s;
                    s = (Shape)shapesArray[j];
                    if (s != null)
                    {
                        s.Draw(g);
                        Console.WriteLine(s.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Wrong shape in array");
                    }
                }
            }

        }

    }
}