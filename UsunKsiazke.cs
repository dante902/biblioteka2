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
     partial class UsunKsiazke : Form
    {
        Biblioteka bib;
        
        
        public UsunKsiazke(Biblioteka bibl)
        {
            this.bib = bibl;
            InitializeComponent();
        }

        private void UsunKsiazke_Load(object sender, EventArgs e)
        {
            foreach (Ksiazki k in bib.ksiazki)
            {
                comboBox1.Items.Add(k.Opis());
            }
            if (bib.ksiazki.Count == 0)
            {
                btnRemove.Visible = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<bib.wypozyczenia.Count;i++)
            {
               if  (bib.wypozyczenia[i].ToString().Contains(bib.ksiazki[comboBox1.SelectedIndex].ToString()))
               {
                   MessageBox.Show("posiadaja");
               }
               else
               {
                   MessageBox.Show("Ni ma");
               }
            }
          //  bool wypoz = bib.wypozyczenia.Contains(new Wypozyczenie(bib.ksiazki[comboBox1.SelectedIndex].GetType(),Ksiazki k));
           // string result = bib.wypozyczenia.Find(item => item.zapis().ToString() == bib.ksiazki[comboBox1.SelectedIndex].Opis().ToString());


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
