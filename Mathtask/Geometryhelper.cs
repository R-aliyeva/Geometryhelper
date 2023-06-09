using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathtask
{
    public static class Areaofcircle
    {
        public static double radius;
        public static double area;
        public static void areaofcircle(double radius)
        {

            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(area);
        }

    }
    public static class Areaofrectangular

    {
        public static double a;
        public static double b;
        public static double area1;
        public static void areaofrectangular(double a, double b)
        {
            area1 = a * b;
            Console.WriteLine(area1);

        }

    }
    public static class Areaoftriangle
    {
        public static double a;
        public static double b;
        public static double c;
        public static double area2;
        public static double p;

        public static void areaoftriangle(double a,double b,double c)
        {
            p = (a + b + c);
            area2 = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(area2);

        }

    }
}
