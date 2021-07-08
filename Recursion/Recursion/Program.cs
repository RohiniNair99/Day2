using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the level: ");
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Points: {Points(levels)}");
            Console.ReadLine();
        }


        static int Points(int levels)
        {
            //your code goes here
            if (levels == 1)
                return 1;
            else
            {
                return levels + Points(levels - 1);
            }


        }
    }
    }

