using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class _2TypyZmiennychIRzutowanie
    {
        public _2TypyZmiennychIRzutowanie()
        {
            Console.Write(Environment.NewLine);

            string tekst = "Wyświetlmy parę liczb!";
            int a = 100;
            short b = 1;
            double c = 123.456;
            bool klamca = false;

            Console.WriteLine(tekst);
            Console.Write(a + " " + b + " " + " " + c + " " + klamca);
            Console.Write(Environment.NewLine);
            Console.Write("{0}, {1}, {2}, {3}", a, b, c, klamca); //alternatywny sposob wyświetlania
        }
    }
}
