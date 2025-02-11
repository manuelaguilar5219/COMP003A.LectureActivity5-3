namespace COMP003A.LectureActivity5_3
{
    /// <summary>
    /// Represents a generic shape with an abstract method.
    /// </summary>
    abstract class Shape
    {
        // Auto-implemented property
        public string Name { get; set; }

        /// <summary>
        /// Abstract method to calculate area.
        /// </summary>
        public abstract double CalculateArea();

        /// <summary>
        /// Displays the shape's name.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
namespace COMP003A.LectureActivity5_3
{
    /// <summary>
    /// Represents a circle delived from Shape.
    /// </summary>
    class Circle : Shape, IDrawable
    {
        // Auto-implemented property
        public double Radius { get; set; }

        /// <summary>
        /// Constructor for Circle.
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius )
        {
            Name = "Circle";
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        public override double CalculateArea()
        {
            // Returns the area of the circle
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Implements Draw() method for a circle.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
}
namespace COMP003A.LectureActivity5_3
{
    /// <summary>
    /// Represents a rectangle derived from Shape.
    /// </summary>
    class Rectangle : Shape, IDrawable
    {
        // Auto-implemented properties
        public double Width { get; set; }
        public double Height { get; set; }

        /// <summary>
        /// Constructor for Rectangle.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        public override double CalculateArea()
        {
            // Returns the are of the rectangle
            return Width * Height;
        }

        /// <summary>
        /// Implements Draw() method for a rectangle.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
namespace COMP003A.LectureActivity5_3
{
    /// <summary>
    /// Defines a contract for drawable objects.
    /// </summary>
    interface IDrawable
    {
        /// <summary>
        /// Draws the object.
        /// </summary>
        void Draw();
    }
}
namespace COMP003A.LectureActivity5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a circle and a rectangle
            Shape myCircle = new Circle(5);
            // Create a rectangle
            Shape myRectangle = new Rectangle(4, 6);

            // Display information about the circle
            myCircle.DisplayInfo();
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");
            ((IDrawable)myCircle).Draw();

            // Display information about the rectangle
            myRectangle.DisplayInfo();
            Console.WriteLine($"Area: {myRectangle.CalculateArea()}");
            ((IDrawable)myRectangle).Draw();
        }
    }
}
