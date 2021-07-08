using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Program
    {
        enum Lights{Green,Red,Yellow };
        static void Main(string[] args)
        {
            Array values = Enum.GetValues(typeof(Lights));
            Random random = new Random();
            Lights x = (Lights)values.GetValue(random.Next(values.Length));
            Console.WriteLine(x);
            switch (x)
            {
                case Lights.Green:
                    Console.WriteLine("Go");
                    break;
                case Lights.Red:
                    Console.WriteLine("Stop");
                    break;
                case Lights.Yellow:
                    Console.WriteLine("Ready");
                    break;

            }
            Console.ReadLine();
            
        }
    }
}
