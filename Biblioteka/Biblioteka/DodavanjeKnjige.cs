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
    public partial class DodavanjeKnjige : Form
    {
        public DodavanjeKnjige()
        {
            InitializeComponent();
            CenterToParent();
            radioButtonOstalo.Checked = true;
            Ostalo();
        }

        string naziv, ime_autora, prezime_autora, zanr;
        int dan, mesec, godina;

        private void Ostalo()
        {
            labelDan.Visible = false;
            labelMesec.Visible = false;
            labelGodina.Visible = false;
            numericUpDownDan.Visible = false;
            numericUpDownMesec.Visible = false;
            numericUpDownGodina.Visible = false;
            textBoxZanr.Visible = true;
            labelZanr.Visible = true;
        }

        private void Ljubavni()
        {
            labelZanr.Visible = false;
            textBoxZanr.Visible = false;
            labelDan.Visible = true;
            labelMesec.Visible = true;
            labelGodina.Visible = true;
            numericUpDownDan.Visible = true;
            numericUpDownMesec.Visible = true;
            numericUpDownGodina.Visible = true;
        }

        private void Kriminalistika()
        {
            labelZanr.Visible = false;
            textBoxZanr.Visible = false;
            labelDan.Visible = false;
            labelMesec.Visible = true;
            labelGodina.Visible = true;
            numericUpDownDan.Visible = false;
            numericUpDownMesec.Visible = true;
            numericUpDownGodina.Visible = true;
        }

        private void NFantastika()
        {
            labelZanr.Visible = false;
            textBoxZanr.Visible = false;
            labelDan.Visible = false;
            labelMesec.Visible = false;
            labelGodina.Visible = true;
            numericUpDownDan.Visible = false;
            numericUpDownMesec.Visible = false;
            numericUpDownGodina.Visible = true;
        }

        private void DodavanjeKnjige_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonNaucnaFantastika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNaucnaFantastika.Checked)
                NFantastika();
        }

        private void radioButtonLjubavni_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLjubavni.Checked)
                Ljubavni();
        }

        private void radioButtonKriminalistika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKriminalistika.Checked)
                Kriminalistika();
        }

        private void radioButtonOstalo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOstalo.Checked)
                Ostalo();
        }

        private void DodajKnjigu(object sender, EventArgs e)
        {
            try
            {
               
                naziv = textBoxNazivKnjige.Text;                
                ime_autora = textBoxImeAutora.Text;              
                prezime_autora = textBoxPrezimeAutora.Text;
                dan =(int) numericUpDownDan.Value;
                mesec = (int)numericUpDownMesec.Value;
                godina = (int)numericUpDownGodina.Value;

                if (radioButtonNaucnaFantastika.Checked)
                {
                    using (StreamWriter sr = File.AppendText("NaucnaFantastika.txt"))
                    {
                        Knjiga knjiga = (Knjiga)(new NaucnaFantastika(godina,naziv,ime_autora,prezime_autora));
                        string s = knjiga.Ispis();
                        sr.WriteLine(s);
                    }
                }
                else if (radioButtonLjubavni.Checked)
                {
                    using (StreamWriter sr = File.AppendText("Ljubavni.txt"))
                    {
                        Knjiga knjiga = (Knjiga)(new Ljubavni(dan,mesec,godina, naziv, ime_autora, prezime_autora));
                        string s = knjiga.Ispis();
                        sr.WriteLine(s);
                    }
                }
                else if (radioButtonKriminalistika.Checked)
                {
                    using (StreamWriter sr = File.AppendText("Kriminalistika.txt"))
                    {
                        Knjiga knjiga = (Knjiga)(new Kriminalistika( mesec, godina, naziv, ime_autora, prezime_autora));
                        string s = knjiga.Ispis();
                        sr.WriteLine(s);
                    }
                }
                else
                {
                    zanr = textBoxZanr.Text;
                    using (StreamWriter sr = File.AppendText("Ostalo.txt"))
                    {
                        Knjiga knjiga = (Knjiga)(new OstaliZanrovi(zanr, naziv, ime_autora, prezime_autora));
                        string s = knjiga.Ispis();
                        sr.WriteLine(s);
                    }
                }
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            i++;
            if (i == 100)
            {
                timer1.Stop();
                MessageBox.Show("Uspesno ste uneli knjigu u bazu biblioteke");
                progressBar1.Value = 0;
                i = 1;
            }
        }
    }
}
