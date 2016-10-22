using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class _2_ConsoleWriteLine
    {
        public _2_ConsoleWriteLine()
        {
            Console.Write(Environment.NewLine);

            string imie = "Marek";
            Console.WriteLine("Cześć " + imie + "!");
            Console.WriteLine("Cześć {0}!", imie);

            int wiek = 20;
            Console.WriteLine("Cześć! Jestem {0}. Mam {1} lat. Za 5 lat będę miał {2} lat.", imie, wiek, wiek + 5);
        }
    }
}
