using AreaAnyTriangle.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AreaAnyTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            Console.WriteLine("Calculation to triangle areas and to find out the biggest one");
            Console.WriteLine("");
            Console.Write("Enter the number of triangles to calculate the area: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the side measures (a, b, c) of the triangle: #{i}");
                string[] sides = Console.ReadLine().Split(' ');

                double aSide = double.Parse(sides[0], CultureInfo.InvariantCulture);
                double bSide = double.Parse(sides[1], CultureInfo.InvariantCulture);
                double cSide = double.Parse(sides[2], CultureInfo.InvariantCulture);

                triangles.Add(new Triangle(aSide, bSide, cSide));
                Console.WriteLine("");
            }

            double biggestArea = 0;
            int count = 1;
            foreach (Triangle shape in triangles)
            {
                double area = shape.Area();
                Console.WriteLine($"Triangle #{count} area = {area.ToString("F4", CultureInfo.InvariantCulture)}");
                count++;
                if (area > biggestArea)
                {
                    biggestArea = area;
                }
            }

            Console.WriteLine("");
            Console.Write($"The biggest area: {biggestArea.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
