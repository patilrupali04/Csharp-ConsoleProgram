﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class BreakContinue
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(i);
                 if(i == 10)
                    break;
            }



            Console.WriteLine("Another Loop");
            for(int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);

            }



        }
    }
}
