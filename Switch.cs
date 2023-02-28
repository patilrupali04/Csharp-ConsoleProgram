using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Number");
            int UserNumber=Convert.ToInt32(Console.ReadLine()); 
            switch (UserNumber)
            {
                case 1:
                    Console.WriteLine("This is a UserNumber one");
                    break;
                    
                case 2:
                    Console.WriteLine("This is a UserNumber Two");
                    break;
                case 3:
                    Console.WriteLine("This is a UserNumber Three");
                    break;
                default:
                    Console.WriteLine("This is not UserNumber one, Two & Three");
                    break;

            }
        }
    }
}
