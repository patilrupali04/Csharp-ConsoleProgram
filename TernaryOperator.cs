using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number = 15;
            //int AnotherNumber = 10;
            //if(Number==15 && AnotherNumber == 10)
            //{
            //    Console.WriteLine("Hello");
            //}
            //else if(Number==15 || AnotherNumber == 20)
            //{
            //    Console.WriteLine("Hi");
            //}
            //else
            //{
            //    Console.WriteLine("Never");
            //}

            bool IsNumber10;
            IsNumber10=Number==10?true:false;
            Console.WriteLine("Number is {0}", IsNumber10);
        }
    }
}
