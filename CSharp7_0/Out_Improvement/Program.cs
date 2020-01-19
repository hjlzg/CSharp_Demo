using System;
using System.Text;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //C#7.0

            //1.输出变量

            SetPoints(out var x, out var y);

            Console.WriteLine(x);
            Console.WriteLine(y);
        }


      public static void SetPoints(out int x, out int y)
        {
            x = 100;
            y = 200;
        }
       
    }
}