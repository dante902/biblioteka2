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
     partial class DodajKsiazke : Form
    {
        Biblioteka bibl;
        public DodajKsiazke(Biblioteka bibl)
        {
            this.bibl = bibl;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bibl.dodajKsiazke(new Ksiazki(txtAutor.Text, txtTitle.Text, txtISBN.Text, Int32.Parse(txtCount.Text)));
                txtAutor.Clear();
                txtTitle.Clear();
                txtISBN.Clear();
                txtCount.Clear();
            }
            catch
            {
                MessageBox.Show("Podaj poprawną liczbe egzemplarzy");
                txtAutor.Clear();
                txtTitle.Clear();
                txtISBN.Clear();
                txtCount.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
