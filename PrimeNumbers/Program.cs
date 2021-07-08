using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 2,flag=0;
            Console.WriteLine("Enter the number till which the prime number is to be displayed: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            while(prime<=limit)
            {
                for(int loop=2;loop<=prime/2;loop++)
                {
                    if(prime%loop==0)
                    {
                        flag = 1;
                        break;
                    }
                    
                }
                if(flag==0)
                {
                    Console.WriteLine($"{prime}");
                }
                prime++;
            } 

            }
        }
    }
         
