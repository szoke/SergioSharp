﻿using System;
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
            DoFunStuffWithArrays();
            DoFunWithClasses();
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

        private static void DoFunStuffWithArrays()
        {
            // A tömbökben több ugyanolyan típusú elemet lehet tárolni

            // Csináljunk egy 3 elemű tömböt
            int[] ints = new int[3];

            // Töltsük fel
            // A tömbelemeket indexeléssel érjük el, az indexek 0-tól kezdődnek
            // Az utolsó elem indexe ezért length - 1, itt 3 - 1 = 2
            ints[0] = 45;
            ints[1] = 46;
            ints[2] = 47;

            // for ciklussal végigmegyünk a tömb összes elemén és kiiratjuk őket
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine("A tömb " + i + ". eleme: " + ints[i]);
            }

            // Tömb létrehozása az elemek felsorolásával
            int[] intsTwo = new int[] { 5, 8, 4, 7, 8, 9, 4, 1, 2, 4, 5, 6, 5, 4 };
            Console.WriteLine(intsTwo.Length + " darab elem van a felsorolással létrehozott tömbben.");

            // for ciklussal kiiratjuk az utolsó 3 elemet
            int indexOfLastElement = intsTwo.Length - 1;
            for (int i = indexOfLastElement; i > indexOfLastElement - 3; i--)
            {
                Console.WriteLine("A tömb " + i + ". eleme: " + intsTwo[i]);
            }

            // TODO: játszani for ciklusokkal

            Console.ReadLine();
        }

        private static void DoFunWithClasses()
        {
            // Az osztály egy sablon, egy definíció
            // Az objektum egy osztálynak egy példánya
            // Egy osztályból tetszőleges számú példányt hozhatunk létre, amik egyedi azonosítóval fognak rendelkezni
            // Itt 2 példányt hozunk a Player osztályból
            Player playerOne = new Player();
            Player playerTwo = new Player();

            // A létrejött objektumok Player típusúak lesznek
            // Az is operátorral megvizsgálhatjuk, hogy tényleg így van-e
            Console.WriteLine("playerOne is Player: " + playerOne is Player);
            Console.WriteLine("playerTwo is Player: " + playerTwo is Player);

            // Nézzük meg, hogy a két példány "egyenlő-e" - Az eredmény false lesz, mert ezek más-más példányai a Player osztálynak
            Console.WriteLine("playerOne.Equals(playerTwo): " + playerOne.Equals(playerTwo));

            // A két példány hashCode-ja mutatja, hogy nem azonosak
            Console.WriteLine("playerOne.GetHashCode(): " + playerOne.GetHashCode());
            Console.WriteLine("playerTwo.GetHashCode(): " + playerTwo.GetHashCode());

            // A harmadik példányt nem new kulcsszóval hoztuk létre, hanem értékül adtuk neki a playerOne-t
            // Így továbbra is csak 2 objektumunk van, nem jött létre harmadik
            // A kettőből az egyiket viszont innentől a playerOne és a playerThree változón keresztül is elérjük, míg a másikat csak a playerTwo változón keresztül
            Player playerThree = playerOne;

            // playerOne és playerThree hashCode-ja ugyanaz, mivel ugyanaz az objektum "van bennük"
            Console.WriteLine("playerThree.GetHashCode(): " + playerThree.GetHashCode());

            // true
            Console.WriteLine("playerThree.Equals(playerOne): " + playerThree.Equals(playerOne));

            // false
            Console.WriteLine("playerThree.Equals(playerTwo): " + playerThree.Equals(playerTwo));

            Console.ReadLine();
        }
    }
}
