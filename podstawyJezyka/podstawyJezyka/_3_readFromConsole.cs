using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class _3_readFromConsole
    {
        public _3_readFromConsole()
        {
            Console.Write(Environment.NewLine);

            string imie1 = "Marek";
            Console.WriteLine("Cześć " + imie1 + "!");
            Console.WriteLine("Cześć {0}!", imie1);

            int wiek = 20;
            Console.WriteLine("Cześć! Jestem {0}. Mam {1} lat. Za 5 lat będę miał {2} lat.", imie1, wiek, wiek + 5);


            string imie;
            string kierunek_studiow;
            string tmp;
            int stopien;
            int rok;


            Console.Write("Podaj swoje imię: ");
            imie = Console.ReadLine();
            Console.Write("Podaj kierunek studiów: ");
            kierunek_studiow = Console.ReadLine();
            Console.Write("Który stopień?: ");
            tmp = Console.ReadLine();
            stopien = Int32.Parse(tmp);
            Console.Write("Który rok?: ");
            tmp = Console.ReadLine();
            rok = Int32.Parse(tmp);

            Console.WriteLine("***{0}***\nKierunek studiów: {1}\nStopień {2} rok {3}.", imie, kierunek_studiow, stopien, rok);
        }
    }
}
