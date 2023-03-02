using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class doWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Target");
            int UserChoice = int.Parse(Console.ReadLine());
            int fixValue = 0;
            do
            {
                fixValue=fixValue+1;
                Console.WriteLine("fixvalue {0}", fixValue);
                
               
            } while (fixValue<=UserChoice);   //do while loop check the condition at the end of the loop
            
            //do loop is guaranted to execute at least once
        }
    }
}
