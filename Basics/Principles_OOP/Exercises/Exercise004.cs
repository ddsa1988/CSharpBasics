using Basics.Principles_OOP.Models;

namespace Basics.Principles_OOP.Exercises;
public class Exercise004 {
    /*
    Define an abstract class Shape with abstract method CalculateSurface() and fields width and height.
    Define two additional classes for a triangle and a rectangle, which implement CalculateSurface(). 
    This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2).
    Define a class for a circle with an appropriate constructor, which initializes the two fields 
    (height and width) with the same value (the radius) and implement the abstract method for calculating the area. 
    Create an array of different shapes and calculate the area of each shape in another array.
    */
    public static void UserMain() {
        Shape[] shapes = [
            new Triangle(10,20),
            new Rectangle(20,30),
            new Circle(40)
        ];

        foreach (Shape shape in shapes) {
            Console.WriteLine("{0} area: {1:F2}", shape.GetType().Name, shape.CalculateArea());
        }
    }
}
