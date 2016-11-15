using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class Prostokat
    {
        public int obwodProstokata(int a, int b)
        {
            return 2 * a + 2 * b;
        }

        public int poleProstokata(int a, int b)
        {
            return a * b;
        }

        //2.7.4
        public int a, b;
        public Prostokat()
        {
            a = 4;
            b = 6;
            Console.Write("Prostokąt o domyślnych parametrach: ");
        }
        public Prostokat(int a)
        {
            this.a = a;
            b = a;
            Console.Write("To jest kwadrat! ");
        }
        public Prostokat(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.Write("To jest prostokąt o bokach ");
        }
        public override string ToString()
        {
            return "a = " + a + " " + "| b = " + b;
        }
    }
}
