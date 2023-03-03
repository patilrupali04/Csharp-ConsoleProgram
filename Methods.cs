using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleProject
{
    internal class Methods
    {
        public static void Main(string[] args)
        {

            Methods.OddNumber(20);   //static method invoked by class name

            Methods m=new Methods();
            int Sum = m.Add(20, 30);   //instance method invoked by instance of class name
            Console.WriteLine("Sum is {0} ", Sum);

        }

        public int Add(int first, int second)    //Instatnce Method
        {
            return first+ second;
        }

        public static void OddNumber(int Target)   //Static method
        {
            
            for(int i=0; i<=Target;i++)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
                
            }
        }


        /* Difference between instance method and static method is that multiple
         instances of the class can be created and each instance has its own separate
        method .but in the case of static method there is only one way of defining static mehtod */
    }
}
