using System.Drawing;


//sort this out comment wise
namespace SimplifiedProgrammingLanguage
{
    abstract class Shape : ShapesInterface
    {
        protected float x, y; 
        public Shape()
        {
            
        }
        
        public Shape(float x, float y)
        {
            //pen coordinates
            this.x = x;
            this.y = y;
        }

        //the three methods below are from the shapesInterface
        //here we are passing on the obligation to implement them to the derived classes by declaring them as abstract
        public abstract void Draw(Graphics g); //any derrived class must implement this method
        //set is declared as virtual so it can be overridden by a more specific child version
        //but is here so it can be called by that child version to do the generic stuff
        //note the use of the param keyword to provide a variable parameter list to cope with some shapesArray having more setup information than others
        public virtual void Set(params float[] coordinates)
        {
            x = coordinates[0];
            y = coordinates[1];
        }


        public override string ToString()
        {
            return base.ToString() + "Points: X -  " + this.x + ", Y - " + this.y + " : ";
        }

    }
}

