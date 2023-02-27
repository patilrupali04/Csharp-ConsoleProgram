using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class NullableTypes
    {
        static void Main(string[] args)
        {
            bool ? AreYouMajor = null;
            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if(AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User Did not answer the questions");
            }
        }
    }
}
