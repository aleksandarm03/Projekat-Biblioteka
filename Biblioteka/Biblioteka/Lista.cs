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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader stream = File.OpenText("NaucnaFantastika.txt"))
                {
                    String s = "";
                    while ((s = stream.ReadLine()) != null)
                    {
                        listBoxNFantastika.Items.Add(s);
                    }
                    stream.Dispose();
                }

                using (StreamReader stream = File.OpenText("Kriminalistika.txt"))
                {
                    String s = "";
                    while ((s = stream.ReadLine()) != null)
                    {
                        listBoxKriminalistika.Items.Add(s);
                    }
                    stream.Dispose();
                }

                using (StreamReader stream = File.OpenText("Ljubavni.txt"))
                {
                    String s = "";
                    while ((s = stream.ReadLine()) != null)
                    {
                        listBoxLjubavni.Items.Add(s);
                    }
                    stream.Dispose();
                }


                using (StreamReader stream = File.OpenText("Ostalo.txt"))
                {
                    String s = "";
                    while ((s = stream.ReadLine()) != null)
                    {
                        listBoxOstalo.Items.Add(s);
                    }
                    stream.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        
        }

        private void listBoxNFantastika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxKriminalistika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxLjubavni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOstalo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
