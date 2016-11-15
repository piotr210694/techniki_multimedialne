using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    abstract class Osoba
    {
        private string _imie, _nazwisko;
        private int _dataUrodzenia;

        public abstract void opis();

        public string imie
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

        public string nazwisko
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

        public int dataUrodzenia
        {
            get
            {
                return _dataUrodzenia;
            }
            set
            {
                _dataUrodzenia = value;
            }
        }
    }
}
