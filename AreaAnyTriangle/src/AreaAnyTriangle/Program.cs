using AreaAnyTriangle.Entities;
using AreaAnyTriangle.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AreaAnyTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeaderMessage();
            int n = HowManyTriangles();

            try
            {
                List<Triangle> triangles = EnterTriangleSideMeasures(n);

                double biggestArea;
                CalculateArea(triangles, out biggestArea);
                DisplayBiggestArea(biggestArea);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (MeasuresException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TriangleMeasureException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ApplicationException e)
            {
                Console.WriteLine("Error unknown: " + e.Message);
            }

        }

        static void PrintHeaderMessage()
        {
            Console.WriteLine("Calculation to triangle areas and to find out the biggest one");
            Console.WriteLine("");

        }

        static List<Triangle> EnterTriangleSideMeasures(int n)
        {
            List<Triangle> triangles = new List<Triangle>();

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

            return triangles;

        }

        static int HowManyTriangles()
        {
            Console.Write("Enter the number of triangles to calculate the area: ");
            return int.Parse(Console.ReadLine());
        }

        static void CalculateArea(List<Triangle> triangles, out double biggestArea)
        {
            biggestArea = 0.0;

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

        }

        static void DisplayBiggestArea(double area)
        {
            Console.WriteLine($"The biggest area is: {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
