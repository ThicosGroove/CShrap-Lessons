using System;
using System.Collections.Generic;
using Abstracts_class.Entities;
using Abstracts_class.Entities.Enums;

namespace Abstracts_class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int shapeNumbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= shapeNumbers; i++)
            {
                Console.WriteLine($"Shape #{shapeNumbers} data: ");
                Console.Write("Rectangle or Cicle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());               

                if (shape == 'r')
                {
                    Console.Write("Widht: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    int height = int.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, height, color));
                }
                else if (shape == 'c')
                {
                    Console.Write("Radius: ");
                    int radius = int.Parse(Console.ReadLine());

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");

            foreach  (Shape shape in list)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}
