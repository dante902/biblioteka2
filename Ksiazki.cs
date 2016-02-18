using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_program
{
    class Ksiazki
    {
        public string autor { get; set; }
        private string tytul { get; set; }
        private string isbn { get; set; }
        private int ilosc_egzemplarzy { get; set; }
        private int ilosc_wypozyczonych_egzemplarzy { get; set; }

        public Ksiazki(string autor, string tytul, string isbn, int ilosc_egzeplarzy)
        {
            this.autor = autor;
            this.tytul = tytul;
            this.isbn = isbn;
            this.ilosc_egzemplarzy = ilosc_egzeplarzy;
        }
        
        
        public bool Wypozycz()
        {
            if (ilosc_egzemplarzy - ilosc_wypozyczonych_egzemplarzy > 0)
            {
                ilosc_wypozyczonych_egzemplarzy += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Oddaj()
        {
            if (true)
            {
                ilosc_wypozyczonych_egzemplarzy--;
                return true;
            }
        }
        public string Opis()
        {
            return autor + ", " + tytul + " (egz.: " + ilosc_egzemplarzy + ", wyp.:" + ilosc_wypozyczonych_egzemplarzy + ")";
        }
        public string Opis_krotki()
        {
            return autor + ", " + tytul;
        }


    }
}
