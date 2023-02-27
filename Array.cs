using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Array
    {
        static void Main(string[] args)
        {
            //Array is collection of Similar Datatypes

            int[] EvenNum = new int[4];
            EvenNum[0] = 2;        //Array is Strongly Typed
            EvenNum[1] = 4;
            EvenNum[2] = 6;
            EvenNum[3] = 8;
          //  EvenNum[4] = 10;     Disadvantage-Array cannot grows once initialized  

            Console.WriteLine("EvenNumber is : {0}", EvenNum[2]);
        }
    }
}
