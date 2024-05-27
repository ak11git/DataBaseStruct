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
    public partial class DodajVlasnikaPravno : Form
    {
        NekretninaBasic nekretnina;
        public DodajVlasnikaPravno(NekretninaBasic n)
        {
            InitializeComponent();
            nekretnina = n;
        }

        private void DodajVlasnika_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VlasnikBasic v = new VlasnikBasic();
            v.Ime = textBox1.Text;
            v.Drzava = textBox2.Text;
            //v.Nekretnine = nekretnina;
            //DTOManager.sacuvajOdeljenjeDo5(o);
            MessageBox.Show("Uspesno ste dodali novog vlasnika!");
            this.Close();
        }
    }
}
