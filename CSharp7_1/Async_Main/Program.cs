using System;
using System.Threading.Tasks;

namespace Async_Main
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await Task.Delay(1000);

            Console.WriteLine("Wow!");

            Shape s = default;

            Console.WriteLine(s);

            SpanTest();
           
        }

        public static void SpanTest(){
             Span<int> tickets = new int[100];

            var sliceOfTickets = tickets.Slice(50, 10);
        }
    }

    class Shape { };
}
