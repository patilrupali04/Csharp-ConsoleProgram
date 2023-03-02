using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class forLoop
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;


            // A for loop is very similar to while loop. In while loop we do initialization at one place
            // condition check another place, and modifying variable at another place . whereas 
            // for loop has all of these at one place.
            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }


            //foreach loop is used to iterate through the item in a collection

            foreach(int k in Numbers)
            {
                Console.WriteLine(k);
            }
            //int i = 0;
            //while(i < Numbers.Length)
            //{
            //    Console.WriteLine(Numbers[i]);
            //    i++; 
            //}



            
        }
    }
}
