using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_program
{
     partial class WypoczyczKsiazke : Form
    {
        Biblioteka bibl;
        public WypoczyczKsiazke(Biblioteka bibl)
        {
            this.bibl = bibl;
            InitializeComponent();
        }

        private void WypoczyczKsiazke_Load(object sender, EventArgs e)
        {
            foreach (Czytelnik czyt in bibl.czytelnicy )
            {
                cBReader.Items.Add(czyt.opis());
            }
            foreach (Ksiazki k in bibl.ksiazki)
            {
                cBBooks.Items.Add(k.Opis());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bibl.wypozyczKsiazkeCzytelnikowi(bibl.ksiazki[cBBooks.SelectedIndex], bibl.czytelnicy[cBReader.SelectedIndex]);
            
            Dispose();
        }
    }
}
