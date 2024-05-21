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
    public partial class NekretnineForm : Form
    {
        public NekretnineForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajNekretninu forma = new DodajNekretninu();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nekretninu koju zelite da obrišete!");
                return;
            }

            int idProdavnice = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrišete izabranu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                //DTOManager.obrisiProdavnicu(idProdavnice);
                MessageBox.Show("Brisanje nekretnine je uspešno obavljeno!");
                //this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nekretninu čije podatke želite da izmenite!");
                return;
            }

            int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            //NekretninaBasic ne = DTOManager.vratiProdavnicu(idNekretnine);

            //IzmeniNekretninu formaUpdate = new IzmeniNekretninu(ne);
            //formaUpdate.ShowDialog();

            //this.popuniPodacima();
        }
    }
}
