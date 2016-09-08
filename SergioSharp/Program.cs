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
            DoFunStuffWithStrings();
            DoFunStuffWithIntegers();
            DoFunStuffWithFloats();
        }

        private static void DoFunStuffWithStrings()
        {
            // TODO: Kísérletezni stringekkel

            string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld);

            string cSharpIsGreat = "C# is great.";

            // Két string összefűzése kétféleképp
            string concatenatedString = helloWorld + cSharpIsGreat;
            string concatenatedStringTwo = string.Concat(helloWorld, cSharpIsGreat);
            Console.WriteLine("Az egyik konkatenált string: " + concatenatedString);
            Console.WriteLine("A másik konkatenált string: " + concatenatedStringTwo);

            // Substring kivágása
            string subStringOne = helloWorld.Substring(3, 3);
            Console.WriteLine(subStringOne);
            
            Console.ReadLine();
        }

        private static void DoFunStuffWithIntegers()
        {
            int a = 4;
            int b = 5;

            int sum = a + b;
            Console.WriteLine(sum);

            int intMax = int.MaxValue;
            int intMin = int.MinValue;

            // TODO: Különbség, szorzás, osztás, négyzetgyök, stb. a-val és b-vel
            // TODO: Összeadás, különbség, szorzás, osztás, intMax-szal és intMin-nel

            long c;

            // TODO: Elolvasni a long dokumentációját. Segít-e, ha nem megy valami az intMax-szal?

            Console.ReadLine();
        }

        private static void DoFunStuffWithFloats()
        {
            float a = 2f;
            float b = 34.653f;

            float sum = a + b;
            Console.WriteLine(sum);

            // TODO: Különbség, szorzás, osztás, négyzetgyök, stb.

            Console.WriteLine(Math.Sqrt(a));

            // TODO: Megnézni a többi metódust a Math osztályban. Elkezded írni, hogy 'Math.' és a Visual Studio feldobja a lehetőségeket.

            Console.ReadLine();
        }
    }
}
