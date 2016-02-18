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
     partial class DodajCzytelnika : Form
    {
        public Biblioteka bib;
       
        public DodajCzytelnika()
        {     
            InitializeComponent();
        }
        public DodajCzytelnika(Biblioteka bib)
        {
            this.bib = bib;
            InitializeComponent();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
        
            bib.dodajCzytelnika(new Czytelnik(txtName.Text, txtSurname.Text, bib.kolejny_numer_czytelnika()));
            txtName.Clear();
            txtSurname.Clear();
           
        }
    }
}
