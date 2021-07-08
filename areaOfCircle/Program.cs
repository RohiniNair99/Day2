using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius, area;
            Console.WriteLine("enter the radius: ");
            //your code goes here
            radius = Convert.ToDouble(Console.ReadLine());
            area = pi * radius * radius;
            Console.WriteLine($"The area of circle is {area}");
            Console.ReadLine();
        }
    }
}
