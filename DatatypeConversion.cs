using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class DatatypeConversion
    {
        static void Main(string[] args)
        {
            int i = 200;
            float f = i;
            Console.WriteLine("implicit conversion is :{0}",f);

            float value = 12345.34f;
            int value1 = (int)value;
            Console.WriteLine("explicit conversion is: {0}", value1);


            Console.WriteLine("Another Conversion is string to Integer");

            string strNumber = "100";
            int num = int.Parse(strNumber);
            Console.WriteLine(num);

            

            string strNumber2 = "4000tc";
            int Result = 0;
            bool isValueSuccessfull =int.TryParse(strNumber2, out Result); //return type of TryParse() method is boolean
            if (isValueSuccessfull)
            {
                Console.WriteLine(Result);
            }
            else{
                Console.WriteLine("Please enter valid number");
            }


            string strNumber1 = "11oct";
            int num1 = int.Parse(strNumber1);
            Console.WriteLine(num1);


        }
    }
}
