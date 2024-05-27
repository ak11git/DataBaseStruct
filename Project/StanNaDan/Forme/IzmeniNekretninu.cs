using StanNaDan.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StanNaDan.Forme
{
    public partial class IzmeniNekretninu : Form
    {

        public NekretninaBasic nekretnina;
        public KucaBasic kuca;
        public StanBasic stan;
        public SobaBasic soba;
        public IzmeniNekretninu()
        {
            InitializeComponent();
            nekretnina = new NekretninaBasic();
            kuca = new KucaBasic();
            stan = new StanBasic();
            soba = new SobaBasic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izmenite ovu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.nekretnina.TipNekretnine = comboBox1.SelectedItem.ToString();
                this.nekretnina.ImeUlice = textBox2.Text;
                this.nekretnina.KucniBroj = int.Parse(textBox3.Text);
                this.nekretnina.Kvadratura = int.Parse(textBox4.Text);
                this.nekretnina.TipKreveta = comboBox2.SelectedItem.ToString();
                this.nekretnina.Dimenzije = textBox14.Text;
                this.nekretnina.BrojKupatila = (int)numericUpDown1.Value;
                this.nekretnina.BrojTerasa = (int)numericUpDown2.Value;
                this.nekretnina.BrojSoba = (int)numericUpDown3.Value;

                if (comboBox1.SelectedItem.ToString() == "Kuća")
                {
                    numericUpDown4.Enabled = true;
                    checkBox4.Enabled = true;
                    this.kuca.Spratnost = (int)numericUpDown4.Value;
                    this.kuca.Internet = checkBox1.Checked ? 1 : 0;
                    this.kuca.TV = checkBox2.Checked ? 1 : 0;
                    this.kuca.Kuhinja = checkBox3.Checked ? 1 : 0;
                    this.kuca.Dvoriste = checkBox4.Checked ? 1 : 0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Stan")
                {
                    numericUpDown5.Enabled = true;
                    checkBox5.Enabled = true;
                    this.stan.Sprat = (int)numericUpDown5.Value;
                    this.stan.Internet = checkBox1.Checked ? 1 : 0;
                    this.stan.TV = checkBox2.Checked ? 1 : 0;
                    this.stan.Kuhinja = checkBox3.Checked ? 1 : 0;
                    this.stan.Lift = checkBox5.Checked ? 1 : 0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Soba")
                {
                    this.soba.Internet = checkBox1.Checked ? 1 : 0;
                    this.soba.TV = checkBox2.Checked ? 1 : 0;
                    this.soba.Kuhinja = checkBox3.Checked ? 1 : 0;
                }
                if (comboBox1.SelectedItem.ToString() == "Kuća" ||
                comboBox1.SelectedItem.ToString() == "Stan" ||
                    comboBox1.SelectedItem.ToString() == "Soba")
                {
                    DTOManager.AzurirajNekretninu(this.nekretnina, this.nekretnina.ID);
                    MessageBox.Show("Uspesno ste izmenili ovu nekretninu!");
                    this.Close();
                }
                else
                {
                    string poruka1 = "Izaberite Tip Nekretnine";
                    string title1 = "Pitanje";
                    MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                    DialogResult result1 = MessageBox.Show(poruka1, title1, buttons1);
                }
            }
            else
            {

            }
        }
    }
}
