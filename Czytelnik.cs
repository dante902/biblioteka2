using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_program
{
    class Czytelnik
    {
        private string imie { get; set; }
        private string nazwisko { get; set; }
        private long id { get; set; }
        Biblioteka bib;
        
        public Czytelnik(string imie, string nazwisko, long id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.id = id;
        }
        public Czytelnik(Biblioteka bib)
        {
            this.bib = bib;
        }
        public string opis()
        {
            return (imie + " " + nazwisko + " id = " + id);
        }
       
    }
}
