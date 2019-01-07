using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimplifiedProgrammingLanguage
{
    /// <summary>
    /// Class Form1.
    /// Implements Form" />
    /// </summary/>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Shapes array
        /// </summary>
        ArrayList shapesArray = new ArrayList();
        /// <summary>
        /// Gets or sets the pen location.
        /// </summary>
        /// <value>The pen location.</value>
        private PointF penLocation { get; set; }

        /// <summary>
        /// Graphics Class Reference
        /// </summary>
        Graphics g;

        /// <summary>
        /// Initialises a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            g = drawingCanvas.CreateGraphics();
            penLocation = new Point(0, 0);
            g.Clear(Color.White);

        }

        /// <summary>
        /// The pen status
        /// </summary>
        Boolean penStatus = false;
        /// <summary>
        /// Handles the Click event of the RunButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RunButton(object sender, EventArgs e)
        {
            string input = commandInputter.Text;

            string[] commands = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < commands.Length; i++)
            {
                string line = commands[i];
                string[] singleLineCommands = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    commandsParser(singleLineCommands);            
            }
        }
        /// <summary>
        /// Handles the Click event of the saveToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void penStatusButton_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

        }
        public void commandsParser(String[] singleLineCommand)
        {

            ShapeGenerator shapeGenerator = new ShapeGenerator();

            if (singleLineCommand[0].Equals("moveTo"))
            {
                try
                {
                    string[] command = singleLineCommand[1].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    penLocation = new PointF(float.Parse(command[0]), float.Parse(command[1]));

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

            }

            else if (singleLineCommand[0].Equals("Circle"))
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

            else if (singleLineCommand[0].Equals("Triangle"))
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
            else if (singleLineCommand[0].Equals("Rectangle"))
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



            else if (singleLineCommand[0].Equals("Polygon"))
            {
                try
                {
                    string command = singleLineCommand[1];
                    string[] para = command.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    float[] Points = new float[para.Length + 2];
                    Points[0] = penLocation.X;
                    Points[1] = penLocation.Y;
                    for (int ii = 2; ii < Points.Length; ii++)
                    {
                        Points[ii] = float.Parse(para[ii - 2]);
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

            else if (singleLineCommand[0].Equals("Repeat"))
            {

                int repeatAmount = int.Parse(singleLineCommand[1]);
                //removes the '+' so the radius is there when going through the loop
                string operator_plus = singleLineCommand[3].Replace("+", "");

                //for plus repeat circle
                if (singleLineCommand[2].Equals("Circle"))
                {
                    try
                    {
                        float radius = 0;

                        for (int ii = 0; ii < repeatAmount; ii++)
                        {
                            Shape shape = shapeGenerator.GetShape(singleLineCommand[2]);
                            //repeat quantity is * by the radius 
                            radius += float.Parse(operator_plus);
                            shape.Set(penLocation.X - radius, penLocation.Y - radius, radius);
                            shapesArray.Add(shape);
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);

                    }
                }
                if (singleLineCommand[2].Equals("Rectangle"))
                {
                    try
                    {
                        float height = 0, width = 0;
                        for (int ii = 0; ii < repeatAmount; ii++)
                        {
                            Shape shape = shapeGenerator.GetShape(singleLineCommand[2]);
                            width += float.Parse(operator_plus);
                            height += float.Parse(operator_plus);
                            shape.Set(penLocation.X - Width / 2, penLocation.Y - height / 2, Width, height);
                            shapesArray.Add(shape);
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }

                if (singleLineCommand[2].Equals("Triangle"))
                {
                    try
                    {
                        float bottom = 0, join = 0;
                        for (int ii = 0; ii < repeatAmount; ii++)
                        {
                            Shape shape = shapeGenerator.GetShape(singleLineCommand[2]);
                            bottom += float.Parse(operator_plus);
                            join += float.Parse(operator_plus);
                            shape.Set(penLocation.X - (bottom / (float)(2 + Math.Sqrt(2))), penLocation.Y - (bottom / (float)(2 + Math.Sqrt(2))), bottom, join);
                            shapesArray.Add(shape);
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);

                    }
                }
                for (int ii = 0; ii < shapesArray.Count; ii++)
                {
                    Shape s;
                    s = (Shape)shapesArray[ii];
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Program That Teaches You To Code");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignOutForm f = new SignOutForm();
            this.Hide();
            f.Show();

        }
    }
    }
