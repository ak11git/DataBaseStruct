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
    public partial class IzmeniVlasnikaPravno : Form
    {
        VlasnikBasic vlasnik;
        public IzmeniVlasnikaPravno()
        {
            InitializeComponent();
        }

        public IzmeniVlasnikaPravno(VlasnikBasic v)
        {
            InitializeComponent();
            vlasnik = v;
        }

        public void popuniPodacima()
        {
            textBox1.Text = vlasnik.Ime;
            textBox2.Text = vlasnik.Drzava;
            textBox3.Text = vlasnik.PIB;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vlasnik.Ime = textBox1.Text;
            vlasnik.Drzava = textBox2.Text;
            vlasnik.PIB = textBox3.Text;

            //DTOManager.izmeniOdeljenjeDo5(odeljenje);
            MessageBox.Show("Uspesno ste izmenili vlasnika!");
            this.Close();
        }
    }
}
