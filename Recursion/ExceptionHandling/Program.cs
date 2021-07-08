using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //your code goes here
            try
            {
                Console.WriteLine(" Number of drinks: ");
                int drinks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number of shelves: ");
                int shelves = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(drinks / shelves);
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Input atleast 1 shelf");
                Console.ReadLine();
            }


            catch (Exception e)
            {
                Console.WriteLine("Please insert an integer");
                Console.ReadLine();
            }



        }
    }
    }

