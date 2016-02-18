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
     partial class ZwrotKsiazki : Form
    {
        Biblioteka bibl;
        public ZwrotKsiazki(Biblioteka bibl)
        {
            this.bibl = bibl;
            InitializeComponent();
        }

        private void ZwrotKsiazki_Load(object sender, EventArgs e)
        {
            foreach (Wypozyczenie w in bibl.wypozyczenia)
            {
                cBRents.Items.Add(w.zapis().ToString());
            }
            if (bibl.wypozyczenia.Count == 0)
            {
                btnLend.Visible = false;
            }
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            bibl.usunWypozyczenie(bibl.wypozyczenia[cBRents.SelectedIndex]);
            
            Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
