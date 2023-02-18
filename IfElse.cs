using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            int UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is One");
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine("Your number is Two");
            }
            else if (UserNumber == 3)
            {
                Console.WriteLine("Your number is Three");
            }
            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

        }

    }
}
