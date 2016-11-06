using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.1.3
            Console.WriteLine("Hello World!");
            Console.Write(Environment.NewLine);

            //2.2.1
            bool klamca = false;
            char znak = 'A';
            string tekst = "Przykładowy tekst";
            short x = 12345; //pokazac errora jak wiecej
            int y = 123456789;
            long z = 1234567890123456;
            float xx = 1234.43f;
            double yy = 1234.665;

            Console.WriteLine(klamca + " " + znak + " " + tekst + " " + x + " " + y + " " + z + " " + xx + " " + yy);
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", klamca, znak, tekst, x, y, z, xx, yy);
            Console.Write(Environment.NewLine);

            //2.2.2
            //z double na int
            double d = 4.355;
            int c = (int)d;
            Console.WriteLine("{0}", c);
            //ze string na int
            string text = "1010";
            int liczba = int.Parse(text) + 1; //sprawdzenie czy sie doda, czy działa jak liczba
            Console.WriteLine("{0}", liczba);
            //int na string
            text = liczba.ToString() + 2; //jeśli doklei, to wtedy string
            Console.WriteLine("{0}", text);
            //klasa Convert
            liczba = 1;
            bool logika = Convert.ToBoolean(liczba);
            Console.WriteLine("{0}", logika);
            Console.Write(Environment.NewLine);

            //2.2.3
            const int rok = 2014;
            //rok = rok + 1; // tak nie da rady, nie mozna zmienic pierwszej wartosci
            Console.WriteLine("Za rok będzie już {0} rok!", rok + 1); // mozna tylko wyswietlic
            Console.Write(Environment.NewLine);

            //2.2.4
            liczba = 2014;
            Console.WriteLine("Produkt kosztuje {0:C}!", liczba);   //C
            Console.WriteLine("Liczba dziesiętna {0:D6}.", liczba); //D
            Console.WriteLine("Miejsca po przecinku: {0:F3}.", liczba); //F
            Console.WriteLine("System szesnastkowy: {0:X}", liczba);   //X
            Console.Write(Environment.NewLine);

            /***************************************************************/
            //2.3.1
            int x1, x2;
            x1 = 10; x2 = 5;
            Console.WriteLine("{0} + {1} = {2}", x1, x2, x1 + x2);
            Console.WriteLine("{0} - {1} = {2}", x1, x2, x1 - x2);
            Console.WriteLine("{0} * {1} = {2}", x1, x2, x1 * x2);
            Console.WriteLine("{0} / {1} = {2}", x1, x2, x1 / x2);
            Console.WriteLine("{0} % {1} = {2}", x1, x2, x1 % x2); //modulo - reszta z dzielenia
            //
            int zmienna = 10;
            zmienna = zmienna + 10;
            Console.WriteLine("{0}", zmienna);
            zmienna += 10;
            Console.WriteLine("{0}", zmienna);
            //
            zmienna++;
            Console.WriteLine("{0}", zmienna);
            zmienna--;
            Console.WriteLine("{0}", zmienna);
            Console.Write(Environment.NewLine);

            //2.3.2
            bool prawda = true, falsz = false;
            Console.WriteLine(prawda && falsz);
            Console.WriteLine(prawda || falsz);
            Console.WriteLine(!prawda);
            Console.WriteLine(prawda ^ prawda);
            Console.Write(Environment.NewLine);
            //
            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);
            Console.WriteLine(12 << 2);
            Console.WriteLine(12 >> 2);
            //
            int a = 8;
            a <<= 3;            //to samo co a = 8<<3;  8*2*2*2 czyli 64.
            Console.WriteLine(a);
            Console.Write(Environment.NewLine);

            //2.3.3
            int tmp1, tmp2;
            tmp1 = 5; tmp2 = 10;
            Console.WriteLine(tmp1 == tmp2);
            Console.WriteLine(tmp1 < tmp2);
            Console.WriteLine(tmp1 > tmp2);
            Console.WriteLine(tmp1 <= tmp2);
            Console.WriteLine(tmp1 >= tmp2);
            Console.WriteLine(tmp1 != tmp2);
            Console.Write(Environment.NewLine);

            //****************************************************************
            

            /* _1_HelloWorld hello = new _1_HelloWorld();
             _2TypyZmiennychIRzutowanie write = new _2TypyZmiennychIRzutowanie();
             //_3_readFromConsole readFCons = new _3_readFromConsole();
             _5_loopFor lf = new _5_loopFor();
             */

            Console.ReadKey();
        }
    }
}
