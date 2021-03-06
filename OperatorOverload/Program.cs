using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First person: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Points: ");
            int points1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second person: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Points: ");
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
            Console.ReadLine();
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
        public static DancerPoints operator +(DancerPoints a, DancerPoints b)
        {
            string name = a.name + " " + "&" + " " + b.name;
            int points = a.points + b.points;
            DancerPoints total = new DancerPoints(name, points);
            return total;
        }
    }
}
        
