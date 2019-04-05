using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace helloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# Console World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Console.Write(Environment.NewLine);
            Console.WriteLine("bye (^.^)/~~~ ");
            Thread.Sleep(1000);

        }
    }
}
