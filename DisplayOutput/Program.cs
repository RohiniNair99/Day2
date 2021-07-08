using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input Integer is: {input}");
        }
    }
}
