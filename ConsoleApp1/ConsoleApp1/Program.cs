using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            if (isDivisibleBy(x, 2))
            {
                Console.WriteLine("That's even!");
            } else
            {
                Console.WriteLine("That's odd");
            }


        }
        

        static bool isDivisibleBy(int x, int y)
        {
            int remainder = x % y;
            return remainder == 0;
        }

    
    }
}
