using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Target Number");
            int TargetNum = Convert.ToInt32(Console.ReadLine());
            int Value = 0;
            while (Value <= TargetNum)
            {
                Console.WriteLine(Value);
                Value=Value+2;
                    
            }
        }
    }
}
