﻿using StanNaDan.Entiteti;
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
    public partial class VlasniciForm : Form
    {
        public VlasniciForm()
        {
            InitializeComponent();
        }

        public int brojVlasnika = 0;
        private void VlasniciForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.brojVlasnika = 0;

            /*List<VlasnikBasic> listaVlasnika = DTOManager.vratiSveProizvodeBasic();
            this.listView1.Items.Clear();

            foreach (VlasnikBasic vb in listaVlasnika)
            {
                ListViewItem item = new ListViewItem(new string[] { p.BarKod.ToString(), p.Tip, p.Naziv, p.Proizvodjac });
                this.listView1.Items.Add(item);
                this.brojVlasnika++;
            }*/

            textBox1.Text = this.brojVlasnika.ToString();
            this.listView1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika koga zelite da obrisete!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog vlasnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                //DTOManager.obrisiRadnikaIzSistema(idZaposleni);
                MessageBox.Show("Brisanje zaposlenog je uspesno obavljeno!");
                //this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
