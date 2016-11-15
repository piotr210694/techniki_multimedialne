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
            //Console.WriteLine("Hello World!");
            //Console.Write(Environment.NewLine);

            ////2.2.1
            //bool klamca = false;
            //char znak = 'A';
            //string tekst = "Przykładowy tekst";
            //short x = 12345; //pokazac errora jak wiecej
            //int y = 123456789;
            //long z = 1234567890123456;
            //float xx = 1234.43f;
            //double yy = 1234.665;

            //Console.WriteLine(klamca + " " + znak + " " + tekst + " " + x + " " + y + " " + z + " " + xx + " " + yy);
            //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", klamca, znak, tekst, x, y, z, xx, yy);
            //Console.Write(Environment.NewLine);

            ////2.2.2
            ////z double na int
            //double d = 4.355;
            //int c = (int)d;
            //Console.WriteLine("{0}", c);
            ////ze string na int
            //string text = "1010";
            //int liczba = int.Parse(text) + 1; //sprawdzenie czy sie doda, czy działa jak liczba
            //Console.WriteLine("{0}", liczba);
            ////int na string
            //text = liczba.ToString() + 2; //jeśli doklei, to wtedy string
            //Console.WriteLine("{0}", text);
            ////klasa Convert
            //liczba = 1;
            //bool logika = Convert.ToBoolean(liczba);
            //Console.WriteLine("{0}", logika);
            //Console.Write(Environment.NewLine);

            ////2.2.3
            //const int rok = 2016;
            ////rok = rok + 1; // tak nie da rady, nie mozna zmienic pierwszej wartosci
            //Console.WriteLine("Za rok będzie już {0} rok!", rok + 1); // mozna tylko wyswietlic
            //Console.Write(Environment.NewLine);

            ////2.2.4
            //liczba = 2014;
            //Console.WriteLine("Produkt kosztuje {0:C}!", liczba);   //C
            //Console.WriteLine("Liczba dziesiętna {0:D6}.", liczba); //D
            //Console.WriteLine("Miejsca po przecinku: {0:F3}.", liczba); //F
            //Console.WriteLine("System szesnastkowy: {0:X}", liczba);   //X
            //Console.Write(Environment.NewLine);

            ///***************************************************************/
            ////2.3.1
            //int x1, x2;
            //x1 = 10; x2 = 5;
            //Console.WriteLine("{0} + {1} = {2}", x1, x2, x1 + x2);
            //Console.WriteLine("{0} - {1} = {2}", x1, x2, x1 - x2);
            //Console.WriteLine("{0} * {1} = {2}", x1, x2, x1 * x2);
            //Console.WriteLine("{0} / {1} = {2}", x1, x2, x1 / x2);
            //Console.WriteLine("{0} % {1} = {2}", x1, x2, x1 % x2); //modulo - reszta z dzielenia
            ////
            //int zmienna = 10;
            //zmienna = zmienna + 10;
            //Console.WriteLine("{0}", zmienna);
            //zmienna += 10;
            //Console.WriteLine("{0}", zmienna);
            ////
            //zmienna++;
            //Console.WriteLine("{0}", zmienna);
            //zmienna--;
            //Console.WriteLine("{0}", zmienna);
            //Console.Write(Environment.NewLine);

            ////2.3.2
            //bool prawda = true, falsz = false;
            //Console.WriteLine(prawda && falsz);
            //Console.WriteLine(prawda || falsz);
            //Console.WriteLine(!prawda);
            //Console.WriteLine(prawda ^ prawda);
            //Console.Write(Environment.NewLine);
            ////
            //Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);
            //Console.WriteLine(12 << 2);
            //Console.WriteLine(12 >> 2);
            ////
            //int a = 8;
            //a <<= 3;            //to samo co a = 8<<3;  8*2*2*2 czyli 64.
            //Console.WriteLine(a);
            //Console.Write(Environment.NewLine);

            ////2.3.3
            //int tmp1, tmp2;
            //tmp1 = 5; tmp2 = 10;
            //Console.WriteLine(tmp1 == tmp2);
            //Console.WriteLine(tmp1 < tmp2);
            //Console.WriteLine(tmp1 > tmp2);
            //Console.WriteLine(tmp1 <= tmp2);
            //Console.WriteLine(tmp1 >= tmp2);
            //Console.WriteLine(tmp1 != tmp2);
            ////operator warunkowy
            //tmp1 = 30;
            //string war = tmp1 > 100 ? "dużo" : "mało";
            //Console.WriteLine(war);
            //Console.Write(Environment.NewLine);

            ////****************************************************************
            ////2.4.1
            //int warunek = 10;
            //if (warunek < 20)
            //{
            //    Console.WriteLine("{0} jest mniejsze od 20", warunek);
            //}
            //else
            //{
            //    Console.WriteLine("{0} jest większe/równe 20", warunek);
            //}
            ////else if i brak klamr
            //warunek = 5;
            //if (warunek == 10)
            //    Console.WriteLine("{0} jest równe 10", warunek);
            //else if (warunek < 10)
            //    Console.WriteLine("{0} jest mniejsze od 10", warunek);
            //else if (warunek > 10)
            //    Console.WriteLine("{0} jest większe od 10", warunek);
            //Console.Write(Environment.NewLine);

            ////2.4.2
            //string twojaLiczbaText;
            //int twojaLiczba;
            //Console.Write("Podaj liczbę z zakresu 0 - 2: ");
            //twojaLiczbaText = Console.ReadLine(); //console.ReadLine() wczytuje zawsze jako ciąg tekstowy
            //twojaLiczba = int.Parse(twojaLiczbaText);
            //switch (twojaLiczba)
            //{
            //    case 0:
            //        Console.WriteLine("Twoja liczba to {0}", twojaLiczba);
            //        break;
            //    case 1:
            //        Console.WriteLine("Twoja liczba to {0}", twojaLiczba);
            //        break;
            //    case 2:
            //        Console.WriteLine("Twoja liczba to {0}", twojaLiczba);
            //        break;
            //    default:
            //        Console.WriteLine("Twoja liczba przekracza podany zakres!");
            //        break;
            //}
            //Console.Write(Environment.NewLine);

            ////************************************************************
            ////2.5.1
            ////while
            //string haslo = "";
            //while (haslo != "pass")
            //{
            //    Console.Write("Podaj hasło dostępu: ");
            //    haslo = Console.ReadLine();
            //}
            //Console.WriteLine("Dostęp przyznany!");
            ////while nieskonczony - uzycie break do wyjscia z petli
            //string odp = "";
            //while (true)
            //{
            //    Console.Write("Wyjść z pętli? [y/n] ");
            //    odp = Console.ReadLine();
            //    if (odp == "y" || odp == "Y")
            //        break;
            //}
            //Console.WriteLine("Pętla zakończona!");
            ////do-while
            //bool warunek1 = false;
            //string zapetlanie = "";
            //do
            //{
            //    Console.Write("WYŚWIETLIĆ TEN NAPIS JESZCZE RAZ? [Y/N] ");
            //    zapetlanie = Console.ReadLine();
            //    if (zapetlanie == "y" | zapetlanie == "Y")
            //        warunek1 = true;
            //    else
            //        warunek1 = false;
            //} while (warunek1);
            //Console.Write(Environment.NewLine);

            ////2.5.2
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.Write(Environment.NewLine);
            ////for inwersja
            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.Write(Environment.NewLine);
            ////for nieskonczony
            //string end;
            //for (;;)
            //{
            //    Console.Write("Podaj q by zakończyć... ");
            //    end = Console.ReadLine();
            //    if (end == "q")
            //        break;
            //}
            //Console.Write(Environment.NewLine);

            ////2.5.3
            //int[] tablica = { 0, 1, 2, 3, 4 };
            //foreach (int i in tablica)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.Write(Environment.NewLine);

            ////2.6.1
            //int[] tab = new int[5];
            //tab[0] = 5;
            //tab[1] = 3;
            //tab[2] = 10;
            //tab[3] = 7;
            //tab[4] = 22;
            ////a jesli od razu podajemy zawartosc to mozna
            //int[] tab2 = { 5, 3, 10, 7, 22 };
            ////program
            //int[] tab3;
            //int size;
            //Console.Write("Podaj rozmiar tablicy: ");
            //size = int.Parse(Console.ReadLine());
            //tab3 = new int[size];
            //for (int i = 0; i < tab3.Length; i++)
            //{
            //    Console.Write("Podaj wartość tab3[{0}] = ", i);
            //    tab3[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Zawartość twojej tablicy to: ");
            //foreach (int i in tab3)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.Write(Environment.NewLine);

            ////2.6.2
            //int[,] tablica2wym = {
            //        {12, 32, 24, 245, 32},
            //        {35, 36, 36, 87, 62},
            //        {92, 57, 95, 45, 38},
            //        {0, 100, 99, 42, 38}
            //     };
            //Console.WriteLine(tablica2wym[2, 3]);
            ////
            //int row, col;
            //int[,] tab2wym;
            //Console.Write("Podaj ilość wierszy: ");
            //row = int.Parse(Console.ReadLine());
            //Console.Write("Podaj ilość kolumn: ");
            //col = int.Parse(Console.ReadLine());
            //tab2wym = new int[row, col];
            //for(int i = 0; i < row; i++)
            //{
            //    for(int j = 0; j < col; j++)
            //    {
            //        Console.Write("tab2wym[{0}, {1}] = ", i, j);
            //        tab2wym[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < row; i++)
            //{
            //    Console.Write("Wiersz {0})\t", i);
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write("{0} ", tab2wym[i, j]);
            //    }
            //    Console.Write(Environment.NewLine);
            //}
            //Console.Write(Environment.NewLine);

            ////****************************************************

            ////2.7.2
            //Czlowiek admin = new Czlowiek();
            //admin.imie = "Jan";
            //admin.nazwisko = "Kowalski";
            //admin.wiek = 40;
            //Console.Write("{0} {1} ma {2} lat!", admin.imie, admin.nazwisko, admin.wiek);
            //Console.WriteLine("------------------------");

            //Czlowiek c1 = new Czlowiek();
            //c1.imiePriv = "Andrzej5344"; //cyfry nie przejdą
            //Console.WriteLine(c1.imiePriv);
            ////
            //c1.nazwiskoPriv = "Ge"; //za krótkie nazwisko
            //Console.WriteLine(c1.nazwiskoPriv);
            //c1.nazwiskoPriv = "Nowak"; //poprawne nazwisko
            //Console.WriteLine(c1.nazwiskoPriv);
            ////
            //Console.Write("Podaj swój wiek: ");
            //c1.wiekPriv = int.Parse(Console.ReadLine());
            //if (c1.wiekPriv != 0)
            //    Console.WriteLine("Masz {0} lat!", c1.wiekPriv);
            //else
            //    Console.WriteLine("Masz {0} lat?", c1.wiekPriv);

            ////2.7.3
            //Czlowiek czlowiek = new Czlowiek();
            //czlowiek.powitanie("Bogdan");
            //czlowiek.ileMaszLat();
            //Prostokat prostokat = new Prostokat();
            //int obw, pole;
            //obw = prostokat.obwodProstokata(5, 8);
            //pole = prostokat.poleProstokata(5, 8);
            //Console.WriteLine("Obwód = {0}", obw);
            //Console.WriteLine("Pole = {0}", pole);
            ////parametry domyslne w metodzie
            //Kolo kolo = new Kolo();
            //Console.WriteLine(kolo.obwodKola(3.0, 3.1415));
            //Console.WriteLine(kolo.obwodKola(3.0));
            ////dodatkowo
            //dodatekSrednia srednia = new dodatekSrednia();
            //double[] oceny = { 5.0, 4.5, 3.5, 3.0 };
            //Console.WriteLine("Twoja średnia wynosi: " + srednia.srednia(oceny));

            ////2.7.4
            //Czlowiek Andrzej = new Czlowiek("Andrzej", "Kowalski", 55);
            //Czlowiek Tomasz = new Czlowiek("Tomasz", "Wąsik", 28);
            //Andrzej.opiszCzlowieka();
            //Tomasz.opiszCzlowieka();
            ////przeciazanie konstruktorow
            //Prostokat prostokat2 = new Prostokat();
            //Console.WriteLine(prostokat2.ToString());
            //Prostokat prostokat3 = new Prostokat(5);
            //Console.WriteLine(prostokat3.ToString());
            //Prostokat prostokat4 = new Prostokat(5, 10);
            //Console.WriteLine(prostokat4.ToString());

            double c = 123.456;
            int d = (int)c;
            Console.Write(d);

            Console.WriteLine("Produkt kosztuje {0:C5}!", 2014);


            Console.ReadKey();
        }
    }
}
