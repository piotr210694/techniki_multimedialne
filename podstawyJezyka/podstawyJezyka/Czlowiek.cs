using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class Czlowiek
    {
        //2.7.2 ---->
        public string imie, nazwisko;
        public int wiek;

        private string _imie, _nazwisko;
        private int _wiek;

        public string imiePriv
        {
            get
            {
                return _imie;
            }
            set
            {
                //_imie = value;
                for (int i = 0; i < value.Length; i++)
                {
                    if (Convert.ToInt32(char.ToLower(value[i])) >= 97 && Convert.ToInt32(char.ToLower(value[i])) <= 122)
                        _imie += value[i];
                }
            }
        }
        public string nazwiskoPriv
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                // _nazwisko = value;
                if (value.Length < 3)
                    Console.Write("Twoje nazwisko jest za krótkie!");
                else
                    _nazwisko = value;
            }
        }

        public int wiekPriv
        {
            get
            {
                if (_wiek > 0 && _wiek < 100)
                    return _wiek;
                else
                    return 0;
            }
            set
            {
                if (value > 0 && value < 100)
                    _wiek = value;
                else
                    Console.WriteLine("Podałeś niepoprawny wiek!");
            }
        }


        //2.7.3 -->
        public void powitanie(string imie)
        {
            Console.WriteLine("Cześć! Jestem {0} :)", imie);
        }

        public void ileMaszLat()
        {
            Console.Write("Podaj rok urodzenia: ");
            int rok = int.Parse(Console.ReadLine());
            int aktualnyRok = Convert.ToInt32(DateTime.Now.Year);
            Console.WriteLine("Kalendarzowo twój wiek to: {0}", aktualnyRok - rok);
        }

        //2.7.4 -->
        public Czlowiek()
        {

        }
        public Czlowiek(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public void opiszCzlowieka()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Imię: {0}", imie);
            Console.WriteLine("Nazwisko: {0}", nazwisko);
            Console.WriteLine("Wiek: {0}", wiek);
        }
    }
}
