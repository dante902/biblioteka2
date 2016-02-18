using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteka_program
{
     partial class Form1: Form
        {
         Biblioteka bib = new Biblioteka();

        public Form1()
            {
               
                bib.dodajCzytelnika(new Czytelnik("Jan", "Kowalski", bib.kolejny_numer_czytelnika()));
                bib.dodajCzytelnika(new Czytelnik("Dariusz", "Malinowski", bib.kolejny_numer_czytelnika()));
                bib.dodajCzytelnika(new Czytelnik("Wojciech", "Kaminski", bib.kolejny_numer_czytelnika()));
                bib.dodajKsiazke(new Ksiazki("D. Thomas", "Programming Ruby 1.9", "978-1-934356-08-1", 5));
                bib.dodajKsiazke(new Ksiazki("J. Loeliger", "Version Control with Git", "978-0-596-52012-0", 2));
                bib.dodajKsiazke(new Ksiazki("J.E.F. Friedl", "Matering Regular Expressions", "978-0-596-52812-6", 1));
                InitializeComponent();         
            }

        private void zakonczToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void dodajNowegoCzytelnikaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DodajCzytelnika dodajCzyt = new DodajCzytelnika(bib);
            dodajCzyt.ShowDialog();
        }

        private void ążkeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DodajKsiazke dodajKsiaz = new DodajKsiazke(bib);
            dodajKsiaz.ShowDialog();
        }

        private void usunCzytelnikaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UsunCzytelnika usunCzyt = new UsunCzytelnika(bib);
            usunCzyt.ShowDialog();
        }

        private void usunKsiazkeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UsunKsiazke usunKsiazke = new UsunKsiazke(bib);
            usunKsiazke.ShowDialog();
        }

        private void cosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            WypoczyczKsiazke wypozyczenie = new WypoczyczKsiazke(bib);
            wypozyczenie.ShowDialog();
        }

        private void zwrotKsiazkiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZwrotKsiazki zwrot = new ZwrotKsiazki(bib);
            zwrot.ShowDialog();
        }
               
        }
}
