using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Biblioteka
{
    public partial class Clanovi : Form
    {
        public Clanovi()
        {
            InitializeComponent();
            CenterToParent();
            AzurirajListuClanova();
        }

        private void AzurirajListuClanova()
        {
            try
            {
                using (StreamReader stream = File.OpenText("Clanovi.txt"))
                {
                    String s = "";
                    while ((s = stream.ReadLine()) != null)
                    {
                        listBoxClanovi.Items.Add(s);
                    }
                    stream.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DodajClana(object sender, EventArgs e)
        {
            using (StreamWriter sr = File.AppendText("Clanovi.txt"))
            {
                string imeClana = textBoxImeClana.Text;
                string prezimeClana = textBoxPrezimeClana.Text;
                int brojGodina = (int)numericUpDown1.Value;
                Clan c = new Clan(imeClana,prezimeClana,brojGodina);
                string s = c.DodajClana();
                sr.WriteLine(s);
            }
            listBoxClanovi.Items.Clear();
            AzurirajListuClanova();
        }

       
    }
}
