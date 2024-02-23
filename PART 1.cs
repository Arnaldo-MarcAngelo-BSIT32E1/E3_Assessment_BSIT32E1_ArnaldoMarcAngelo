using System;
namespace TriangleAreaCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double baseLength, height, area;
            //get baseLength
            Console.Write("Enter the base Length of the triangle: ");
            if (!double.TryParse(Console.ReadLine(), out baseLength) || baseLength <= 0)
            {
                Console.WriteLine("Please enter a valid  number for the base length.");
                return;
            }
           
            Console.Write("Enter the height of the triangle: ");
            if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Please enter a valid  number for the height.");
                return;
            }
            
            area = 0.5 * baseLength * height;
            Console.WriteLine($"Area of the triangle with base {baseLength} and height {height} is: {area}");
            Console.ReadKey();
        }
    }
}