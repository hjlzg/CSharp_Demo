using System;
using System.Text;

namespace Span
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");

             Span<int> tickets = new int[]{1,2,3,4,5,6,7,8,9};

            var sliceOfTickets = tickets.Slice(2, 2);

            Console.WriteLine(sliceOfTickets.ToString());

            DroosorHotir();
        }

         private static unsafe void DroosorHotir()
        {
            Span<byte> bytes = stackalloc byte[2];
            bytes[0] = 2;
            bytes[1] = 3;

            Console.WriteLine(bytes[0]);
            Console.WriteLine(bytes[1]);
        }

        
    }
}
