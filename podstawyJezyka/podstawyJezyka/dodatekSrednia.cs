using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstawyJezyka
{
    class dodatekSrednia
    {
        public double srednia(double[] oceny)
        {
            double suma = 0.0;
            for(int i = 0; i < oceny.Length; i++)
            {
                suma += oceny[i]; 
            }
            return suma/oceny.Length;
        }
    }
}
