using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_program
{
     class Biblioteka
    {

         public List<Ksiazki> ksiazki { get; set; }
         public List<Czytelnik> czytelnicy { get; set; }
         public List<Wypozyczenie> wypozyczenia { get; set; }
         public long numer_czytelnika { get; set; }
        

        public Biblioteka()
        {            
            this.ksiazki = new List<Ksiazki>();
            this.czytelnicy = new List<Czytelnik>();
            this.wypozyczenia = new List<Wypozyczenie>();
            this.numer_czytelnika = 1;

        }

        public long kolejny_numer_czytelnika()
        {
            return numer_czytelnika++;
        }

        public void dodajKsiazke(Ksiazki k)
        {
            ksiazki.Add(k);
        }
        public void dodajCzytelnika(Czytelnik c)
        {
            czytelnicy.Add(c);
        }
        public void dodajWypozyczenie(Wypozyczenie w)
        {
            wypozyczenia.Add(w);
        }
        public void usunKsiazke(Ksiazki k)
        {
            ksiazki.Remove(k);
        }
        public void usunCzytelnika(Czytelnik c)
        {
            czytelnicy.Remove(c);
        }
        public void usunWypozyczenie(Wypozyczenie w)
        {
            w.Oddaj();
            wypozyczenia.Remove(w);
            
        }
        public bool wypozyczKsiazkeCzytelnikowi(Ksiazki k, Czytelnik c)
        {
            if (k.Wypozycz())
            {
                dodajWypozyczenie(new Wypozyczenie(c, k));
                return true;
            }
            else
            {
                return false;
            }
        }
        
       
    }
}

