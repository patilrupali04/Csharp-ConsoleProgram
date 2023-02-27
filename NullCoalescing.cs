using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class NullCoalescing
    {
        static void Main(string[] args)
        {
            int ? TicketOnSale = 100;
            int AvalaibleTickets = TicketOnSale ?? 0;
            Console.WriteLine("AvailableTickets {0}", AvalaibleTickets);

        }
    }
}
