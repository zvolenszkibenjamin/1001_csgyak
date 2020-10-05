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
            // 2020. 10. 01.

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

            Console.WriteLine("\nA számtani sorozatod első 20 tagja:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{t12n} ");
                t12n += t12d;
            }
            Next();

            // 2020. 10. 05.

            // 13. feladat (szamtanisor3)
            Console.CursorVisible = true;
            Console.Write("13. feladat\nTalálj ki egy számtani sorozatot.\nKérem ennek két szomszédos tagját (szóközzel elválasztva)! ");
            string[] t13szt = Console.ReadLine().Split(' ');
            int t13n = Convert.ToInt32(t13szt[0]), t13d = Convert.ToInt32(t13szt[1]) - t13n;
            Console.CursorVisible = false;

            Console.WriteLine("\nA számtani sorozatod előző és következő 10 tagja:");
            for (int i = -10; i <= 11; i++) Console.Write($"{t13n + (t13d * i)} ");
            Next();

            // 14. feladat (homerseklet_atvaltas)
            Console.WriteLine("14. feladat");
            for (double i = -30; i <= 30; i += 1) Console.WriteLine($"{i} °C = {(i * 1.8) + 32} °F");
            Next();

            // 15. feladat (ketjegyu3)
            Console.WriteLine("15. feladat");
            for (int i = 4; i < 34; i++) Console.Write($"{i * 3} ");
            Next();

            // 16. feladat (osztok)
            Console.CursorVisible = true;
            Console.Write("16. feladat\nKérlek adj meg egy számot! ");
            int t16n = Convert.ToInt32(Console.ReadLine());
            Console.CursorVisible = false;

            Console.Write($"{t16n} osztói: ");
            for (int i = 1; i <= t16n; i++) if (t16n % i == 0) Console.Write($"{i} ");
            Next();

            // 17. feladat (prim_teszt)
            Console.CursorVisible = true;
            Console.Write("17. feladat\nKérlek adj meg egy számot! ");
            int t17n = Convert.ToInt32(Console.ReadLine());
            bool t17isprime = true;
            Console.CursorVisible = false;

            // https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number 0x90 (Yossi Eliaz) megoldása, átalakítva
            if (t17n == 1) t17isprime = false;
            else if (t17n == 2) t17isprime = true;
            else
            {
                var limit = Math.Ceiling(Math.Sqrt(t17n));
                for (int i = 2; i <= limit; ++i) if (t17n % i == 0) t17isprime = false;
            }

            if (t17isprime) Console.WriteLine("Ez a szám prímszám. Osztói 1 és önmaga.");
            else
            {
                int t17oszto = 2;
                while (t17n % t17oszto != 0) t17oszto++;
                Console.WriteLine($"Ez a szám nem prímszám. Osztója pl. a {t17oszto}.");
            }
            Next();

            // 18. feladat (lnko)
            Console.CursorVisible = true;
            Console.Write("18. feladat\nKérlek adj meg két számot (szóközzel elválasztva)! ");
            string[] t18szamok = Console.ReadLine().Split(' ');
            int t18n1 = Convert.ToInt32(t18szamok[0]), t18n2 = Convert.ToInt32(t18szamok[1]), t18gcd = 0;
            Console.CursorVisible = false;

            // https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor Drew Noakes megoldása, átalakítva
            while (t18n1 != 0 && t18n2 != 0)
            {
                if (t18n1 > t18n2) t18n1 %= t18n2;
                else t18n2 %= t18n1;
            }
            t18gcd = t18n1 | t18n2;

            Console.WriteLine($"A két szám legnagyobb közös osztója: {t18gcd}");
            Next();

            // 19. feladat (szim3jegyu)
            Console.WriteLine("19. feladat");
            for (int i = 101; i < 1000; i++) if (i.ToString()[0] == i.ToString()[2]) Console.Write($"{i} ");
            Next();

            // 20. feladat (fibonacci)
            Console.WriteLine("20. feladat");
            int t20val1 = 0, t20val2 = 1, t20val3;
            Console.Write($"{t20val1} {t20val2} ");
            for (int i = 2; i <= 10; i++)
            {
                t20val3 = t20val1 + t20val2;
                Console.Write($"{t20val3} ");
                t20val1 = t20val2;
                t20val2 = t20val3;
            }
            Next();

            // 21. feladat (armstrong)
            Console.WriteLine("21. feladat");
            int t22sum, t22r, t22temp;
            for (int i = 100; i < 1000; i++)
            {
                t22temp = i;
                t22sum = 0;

                while (t22temp != 0)
                {
                    t22r = t22temp % 10;
                    t22temp /= 10;
                    t22sum += t22r * t22r * t22r;
                }
                if (t22sum == i) Console.Write($"{i} ");
            }
            Next();

            // 22. feladat (faktor)
            Console.CursorVisible = true;
            Console.Write("22. feladat\nKérlek adj meg egy számot! ");
            int t22n = Convert.ToInt32(Console.ReadLine());
            int t22f = 1;
            Console.CursorVisible = false;
                
            for (int i = 1; i <= t22n; i++) t22f *= i;
            Console.Write($"A szám faktoriálisa: {t22f} ");
            Next();

            // 23. feladat (6dobas)
            Console.WriteLine("23. feladat");
            int[] t23dk = new int[100];
            Random rnd2 = new Random();
            int t23c = 0;
            Console.Write("Dobások: ");
            for (int i = 0; i < t23dk.Length; i++)
            {
                t23dk[i] = rnd2.Next(1, 7);
                Console.Write($"{t23dk[i]} ");
                if (t23dk[i] == 6) t23c++;
            }
            Console.WriteLine($"\nEzek között {t23c} db 6-os dobás volt.");
            Next();

            // 24. feladat
            Console.WriteLine("24. feladat");
            int[] t24dk1 = new int[20], t24dk2 = new int[20];
            Random rnd3 = new Random();
            int t24c = 0;
            Console.Write("Dobások: ");
            for (int i = 0; i < t24dk1.Length; i++)
            {
                t24dk1[i] = rnd3.Next(1, 7);
                t24dk2[i] = rnd3.Next(1, 7);
                Console.Write($"{t24dk1[i]}-{t24dk2[i]} ");
                if (t24dk1[i] + t24dk2[i] == 12) t24c++;
            }
            Console.WriteLine($"\nEzek között {t24c} db 12-es összegű dobás volt.");
            Next();

            Console.WriteLine("Vége.");
            Console.ReadKey(true);
        }
    }
}
