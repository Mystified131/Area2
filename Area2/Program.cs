using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double radius;

            Console.WriteLine("Let's calculate the area of a circle!");
            Console.WriteLine("The radius of the circle is:");
            radius = double.Parse(Console.ReadLine());

            if (radius > 0) { 

            area = CalculateArea(radius);
                Console.WriteLine("A circle with the radius " + radius + " is a total of " + area);
                Console.ReadLine();
            }

            else

            {
                Console.WriteLine("The number you entered was negative, so no calculation could be made.");
                Console.ReadLine();

            }

        }

        private static double CalculateArea(double radius)
            {
               double area = 3.14 * (radius* radius);
            return area;

            }

        }
    }

