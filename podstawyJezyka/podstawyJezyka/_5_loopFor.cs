using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class _5_loopFor
    {
        public _5_loopFor()
        {
            Console.Write(Environment.NewLine);

            //wyswietl cyfry od 0 do 9
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Write(Environment.NewLine);
            int tmp = 0;
            for(int i = 0; i < 5; i++)
            {
                tmp += i;
                Console.WriteLine(tmp);
            }
        }
    }
}
