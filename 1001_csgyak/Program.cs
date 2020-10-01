using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1001_csgyak
{
    class Program
    {
        static void Next()
        {
            Console.ReadKey(true);
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Nyomj minden feladat után egy gombot, hogy a program tovább menjen.");
            Next();

            // 1. feladat (nev10)
            Console.WriteLine("1. feladat");
            for (int i = 0; i < 10; i++) Console.WriteLine("Zvolenszki Benjámin");
            Next();

            // 2. feladat (ismetlesN)
            Console.CursorVisible = true;
            Console.WriteLine("2. feladat\nKérlek adj meg egy számot! ");
            int t2n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérlek adj meg egy szöveget! ");
            string t2txt = Console.ReadLine();

            Console.CursorVisible = false;
            for (int i = 0; i < t2n; i++) Console.Write(t2txt + " ");
            Next();

            // 3. feladat (visszaszamol)
            Console.WriteLine("3. feladat");
            Thread.Sleep(500);
            for (int i = 10; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nLejárt az időd!");
            Thread.Sleep(1000);
            Next();

            // 4. feladat (nev_mozog)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("4. feladat");
                Console.SetCursorPosition(i * 4, 1);
                Console.Write("Zvolenszki Benjámin");
                Thread.Sleep(500);
                Console.Clear();
            }
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine("4. feladat");
                Console.SetCursorPosition(i * 4, 1);
                Console.Write("Zvolenszki Benjámin");
                Thread.Sleep(500);
                if (i > 0) Console.Clear();
            }
            Next();

            // 5-6. feladat (randomcsillag & randomszin)
            Console.WriteLine("5-6. feladat");
            var t5colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                Console.SetCursorPosition(rnd.Next(0, Console.WindowWidth), rnd.Next(1, Console.WindowHeight));
                Console.ForegroundColor = t5colors[rnd.Next(0, t5colors.Count)];
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Next();

            // 7. feladat (negyzetszamok)
            Console.WriteLine("7. feladat");
            for (int i = 0; i < 31; i++) Console.Write($"{Math.Pow(i, 2)} ");
            Next();

            // 8. feladat (2hatvanyok)
            // a 0. hatványt nem vettem bele, nem tudom az kell -e
            Console.WriteLine("8. feladat");
            for (int i = 1; i < 31; i++) Console.Write($"{Math.Pow(2, i)} ");
            Next();

            // 9-10. feladat (paratlan & paratlan2)
            Console.WriteLine("9-10. feladat");
            for (int i = 1; i <= 100; i++) if (i % 2 != 0) Console.Write($"{i} ");
            Console.Write("\n\n");
            for (int i = 100; i > 0; i--) if (i % 2 != 0) Console.Write($"{i} ");
            Next();

            // 11. feladat (szamtanisor1)
            Console.WriteLine("11. feladat");
            int t11n = 10;
            for (int i = 0; i <= 50; i++)
            {
                Console.Write($"{t11n} ");
                t11n += 7;
            }
            Next();

            // 12. feladat (szamtanisor2)
            Console.CursorVisible = true;
            Console.Write("12. feladat\nTalálj ki egy számtani sorozatot.\nKérem ennek első tagját! ");
            int t12n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem ennek differenciáját! ");
            int t12d = Convert.ToInt32(Console.ReadLine());
            Console.CursorVisible = false;

            Console.WriteLine("A számtani sorozatod első 20 tagja: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{t12n} ");
                t12n += t12d;
            }
            Next();

            Console.WriteLine("Vége.");
            Console.ReadKey(true);
        }
    }
}
