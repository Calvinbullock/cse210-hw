using System;

namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            // test cases
            Square sqr = new Square(2.2, "Blue");
            Rectangle rec = new Rectangle(1, 2, "Red");
            Circle cir = new Circle(2, "green");

            List<Shape> shapes;
            shapes = new List<Shape> { sqr, rec, cir };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetColour());
                Console.WriteLine(shape.GetArea());
                Console.WriteLine();
            }
        }
    }
}

// Return to the Main method in Program.cs to test your code.
// Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
// Create the Rectangle and Circle classes


// Repeat the steps above for the Rectangle and Circle classes, putting them each in their own files, storing the necessary variables, and overriding the GetArea() for each.
// Test these classes back in Main and make sure they work as expected.

// Build a List
// In your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
// Add a square, rectangle, and circle to this list.
// Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.