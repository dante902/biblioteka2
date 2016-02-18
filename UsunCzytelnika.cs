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
    partial class UsunCzytelnika : Form
    {
        Biblioteka bib;
        public UsunCzytelnika(Biblioteka bib)
        {
            this.bib = bib;
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bib.usunCzytelnika(bib.czytelnicy[comboBox1.SelectedIndex]);
            Dispose();
            
            
        }

        private void UsunCzytelnika_Load(object sender, EventArgs e)
        {
            foreach (Czytelnik czyt in bib.czytelnicy)
            {
                comboBox1.Items.Add(czyt.opis());
            }
            if (bib.czytelnicy.Count == 0)
            {
                btnRemove.Visible = false;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
