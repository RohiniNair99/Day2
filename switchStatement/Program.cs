using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOfThree
{
    /* This program prints numbers till the input range and replace multiple of 3 with **/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range : ");
            int number = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            for (int loop = 1; loop <= number; loop++)
            {
                if (loop % 3 == 0)
                {
                    Console.Write("*");
                }
                else
                    Console.Write(loop);
            }
            Console.ReadLine();
        }
        }
    }

