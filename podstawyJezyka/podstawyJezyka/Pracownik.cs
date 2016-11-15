using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class Pracownik : Osoba
    {
        private int _placa;

        public Pracownik(string imie, string nazwisko, int dataUrodzenia, int placa)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.placa = placa;
            Console.WriteLine("---PRACOWNIK---");
            opis();
        }

        public override void opis()
        {
            Console.WriteLine("Imię: {0}", imie);
            Console.WriteLine("Nazwisko: {0}", nazwisko);
            Console.WriteLine("Data urodzenia: {0}", dataUrodzenia);
            Console.WriteLine("Płaca: {0}", placa);
        }

        public int placa
        {
            get
            {
                return _placa;
            }
            set
            {
                _placa = value;
            }
        }
    }
}
