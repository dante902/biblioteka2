using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_program
{
     class Wypozyczenie
    {
        Czytelnik c {get; set;}
        Ksiazki k { get; set; }

        public Wypozyczenie(Czytelnik c, Ksiazki k)
        {
            this.c = c;
            this.k = k;
        }
        public string zapis()
        {
            return k.Opis_krotki() + " -- >" + c.opis() ;
        }
        public bool Oddaj()
        {
            if (true)
            {
                k.Oddaj();
                return true;
            }
            
        }
    }
}
