using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class SwitchContinued
    {
        static void Main(string[] args)
        {
            int TotalCofeeCost = 0;
        Start:
            Console.WriteLine("Please select Cofee size:1-Small, 2-Medium, 3-Large");
            int UserChoice = int.Parse(Console.ReadLine());
        
            switch (UserChoice)
            {
                case 1:
                    TotalCofeeCost += 1;
                    break;
                case 2:
                    TotalCofeeCost += 2;
                    break;
                case 3:
                    TotalCofeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is Invalid please try again...",UserChoice);
                    goto Start; 
            }
            Decide:
            Console.WriteLine("Do you want to buy another cofee Yes or NO?");
                string UserDecision= Console.ReadLine();
            switch(UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("This is invalid choice please try again...{0}",UserDecision);
                    goto Decide;

            }

            Console.WriteLine("Thank You For Shopping With Us");
            Console.WriteLine("Your Bill Amount Is: {0}", TotalCofeeCost);
        }
    }
}
