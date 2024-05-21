using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDan.Forme
{
    public partial class IzmeniNekretninu : Form
    {

        public NekretninaBasic nekretnina;
        public IzmeniNekretninu(NekretninaBasic n)
        {
            InitializeComponent();
            this.nekretnina = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvršite izmene prodavnice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                /*this.nekretnina.TipNekretnine = textBox1.Text;
                this.nekretnina.ImeUlice = textBox2.Text;
                this.nekretnina.KucniBroj = textBox3.Text;
                this.nekretnina.Kvadratura = textBox4.Text;
                this.nekretnina.TipKreveta = textBox8.Text;
                this.nekretnina.Dimenzije = textBox14.Text;
                this.nekretnina.BrojKupatila = numericUpDown1.Value;
                this.nekretnina.BrojTerasa = numericUpDown2.Value;
                this.nekretnina.BrojSoba = numericUpDown3.Value;
                this.nekretnina.Spratnost = numericUpDown4.Value;
                this.nekretnina.Sprat = numericUpDown5.Value;
                this.nekretnina.Internet = checkBox1.Checked;
                this.nekretnina.TV = checkBox2.Checked;
                this.nekretnina.Kuhinja = checkBox3.Checked;
                this.nekretnina.Dvoriste = checkBox4.Checked;
                this.nekretnina.Lift = checkBox5.Checked;

                DTOManager.IzmeniNekretninu(this.nekretnina);
                MessageBox.Show("Azuriranje nekretnine je uspešno izvršeno!");
                this.Close();*/
            }
            else
            {

            }
        }
    }
}
