using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void DodajKnjigu(object sender, EventArgs e)
        {
            Form f = new DodavanjeKnjige();
            f.Show();
        }

        private void ListaKnjiga(object sender, EventArgs e)
        {
            Form f = new Lista();
            f.Show();
        }

        
        private void DodajClana(object sender, EventArgs e)
        {
            Form f = new Clanovi();
            f.Show();
        }
    }
}
