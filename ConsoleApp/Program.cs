using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> myList = new List<Shape>
            {
                new Circle(10.0),
                new Rectangle(2.0, 3.0),
                new Triangle(4.0, 5.0)
            };

            foreach (var shape in myList)
            {
                var result = shape.Area();
                Console.WriteLine("{0:F1}", result);
            }
        }
    }
}