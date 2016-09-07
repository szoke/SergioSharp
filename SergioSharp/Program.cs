using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergioSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintString();
            DoFunStuffWithIntegers();
        }

        private static void PrintString()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void DoFunStuffWithIntegers()
        {
            int a = 4;
            int b = 5;

            int sum = a + b;
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
