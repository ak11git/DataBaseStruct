using System.Windows.Forms;
using NHibernate;
using StanNaDan.Entiteti;

namespace StanNaDan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Ucitavaju se podaci o nekretnini sa zadatim brojem
                Nekretnina n = s.Load<Nekretnina>(61);

                MessageBox.Show(n.ImeUlice + " " + n.Kvadratura + " " + n.TipNekretnine);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Nekretnina n = new Nekretnina();

                n.TipNekretnine = "STAN";
                n.ImeUlice = "Zelengorska";
                n.Internet = 1;
                n.Kvadratura = 43;

                s.Save(n);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziVlasnikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o vlasniku sa zadatim brojem
                Vlasnik v = s.Load<Vlasnik>(5);

                MessageBox.Show(v.Ime + " " + v.Prezime + " " + v.BrojeviTelefona);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziNekretnineVlasnikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Ucitavaju se podaci o vlasniku sa zadatim brojem

                Vlasnik v = s.Load<Vlasnik>(5);
                foreach (Nekretnina n in v.Nekretnine)
                {
                    MessageBox.Show(n.TipNekretnine + " " + n.ImeUlice);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void dodajNekretninuIVlasnikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Email e1 = new Email()
                {
                    EMAIL = "nekiEmail@gmail.com"
                };

                Nekretnina n = new Nekretnina()
                {
                    ImeUlice = "Todora Milovanovica",
                    TipNekretnine = "KUCA",
                    Kvadratura = 150,
                    Dvoriste = 1
                };

                Nekretnina n1 = new Nekretnina()
                {
                    ImeUlice = "Cirila i Metodija",
                    TipNekretnine = "STAN",
                    Kvadratura = 70,
                    Lift = 1
                };

                Vlasnik v = new Vlasnik()
                {
                    Ime = "Milan",
                    Prezime = "Milovanovic",
                    Drzava = "Srbija"
                };

                v.Emailovi.Add(e1);
                e1.Vlasnik = v;
                s.Save(e1);

                v.Nekretnine.Add(n);
                v.Nekretnine.Add(n1);

                n.Vlasnik = v;
                n1.Vlasnik = v;
                s.Save(n);
                s.Save(n1);
                s.Save(v);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void manyToManyNajamNekretnineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nekretnina n1 = s.Load<Nekretnina>(10);

                foreach (ImaNajam im in n1.ListaNajmova)
                {
                    MessageBox.Show(im.Najam.DatumOd.ToString()
                                    + im.Najam.DatumDo.ToString()
                                    + im.Najam.ID.ToString());
                }

                Najam n2 = s.Load<Najam>(3);

                foreach (ImaNajam im in n2.ListaNekretnina)
                {
                    MessageBox.Show(im.Nekretnina.TipNekretnine + " " + im.Nekretnina.ImeUlice);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void poveziNajamNekretninaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Nekretnina n = s.Load<Nekretnina>(10);
                Najam najam = s.Load<Najam>(5);

                ImaNajam im = new ImaNajam();
                im.Najam = najam;
                im.Nekretnina = n;
                //n.ImaNajam.Add(im);
                //najam.ListaNekretnina(im);

                s.Save(im);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziStanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Nekretnina> nekretnine = s.QueryOver<Nekretnina>()
                                                .Where(p => p.TipNekretnine == "STAN")
                                                .List<Nekretnina>();
                Stan st = (Stan)nekretnine[0];
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void dodajStanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                //Vojnik v = new Vojnik();
                Stan st = new Stan();
                st.TipNekretnine = "STAN";
                st.ImeUlice = "Nemanjina";
                st.KucniBroj = 3;
                st.Lift = 1;

                Sajtovi sj = new Sajtovi()
                {
                    Sajt = "www.booking.com/stannadan"
                };

                s.Save(st);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void ispitajTipNekretnineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Nekretnina> nekretnine = s.QueryOver<Nekretnina>()
                                                .List<Nekretnina>();

                foreach (Nekretnina n in nekretnine)
                {
                    if (n.GetType() == typeof(Kuca))
                    {
                        Kuca k = (Kuca)n;
                    }
                    else if (n.GetType() == typeof(Stan))
                    {
                        Stan stan = (Stan)n;
                    }
                    else
                    {
                        Soba soba = (Soba)n;
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void refreshVlasnikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik v = s.Get<Vlasnik>(55);

                //obrada podataka o vlasniku

                s.Refresh(v);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void imePrezimeVlasnikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Vlasnik");

                IList<Vlasnik> vlasnici = q.List<Vlasnik>();

                foreach (Vlasnik v in vlasnici)
                {
                    MessageBox.Show(v.Ime + " " + v.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziPravnoLiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Vlasnik as v where v.JMBG = ''");

                IList<Vlasnik> PravnaLica = q.List<Vlasnik>();

                foreach (Vlasnik v in PravnaLica)
                {
                    MessageBox.Show(v.PIB + " " + v.Naziv);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziFizickoLiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Vlasnik as v where v.PIB = ''");

                IList<Vlasnik> FizickaLica = q.List<Vlasnik>();

                foreach (Vlasnik v in FizickaLica)
                {
                    MessageBox.Show(v.JMBG + " " + v.ImeRoditelja + " " + v.DatumRodjenja);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziNekretninuKvadraturaKuhinja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // paramterizovani upit
                IQuery q = s.CreateQuery("from Nekretnina as n where n.Kvadratura = ? and n.Kuhinja = ?");
                q.SetParameter(0, 200);
                q.SetInt32(1, 1);

                IList<Nekretnina> nekretnine = q.List<Nekretnina>();

                foreach (Nekretnina n in nekretnine)
                {
                    MessageBox.Show(n.ID + " " + n.ImeUlice + " " + n.KucniBroj);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziNekretninuSobaInternet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // paramterizovani upit
                IQuery q = s.CreateQuery("from Nekretnina as n where n.TipNekretnine = :iu and n.Internet = :net");
                q.SetString("iu", "SOBA");
                q.SetInt32("net", 1);

                IList<Nekretnina> nekretnine = q.List<Nekretnina>();

                foreach (Nekretnina n in nekretnine)
                {
                    MessageBox.Show(n.ImeUlice);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziNekretninuParkingBtn_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Nekretnina n where size(n.Parking) > 0");

                IList<Nekretnina> nekretnine = q.List<Nekretnina>();

                if (nekretnine.Count > 0)
                {

                    Nekretnina n = nekretnine[0];
                    MessageBox.Show(n.ID + " " + n.ImeUlice + " " + n.KucniBroj);
                }
                else
                {
                    MessageBox.Show("No properties with parking found.");
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziDrugih5NekretninaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Nekretnina");
                q.SetFirstResult(5); // kreni od 5.
                q.SetMaxResults(5); // uzmi max 5

                IList<Nekretnina> nkr = q.List<Nekretnina>();

                foreach (Nekretnina n in nkr)
                {
                    MessageBox.Show(n.ID.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void enumNekretnineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Nekretnina");

                IEnumerable<Nekretnina> nekretnine = q.Enumerable<Nekretnina>();

                foreach (Nekretnina n in nekretnine)
                {
                    if (n.TipNekretnine == "SOBA")
                        break;
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziKvartStanaVise20Btn_Click(object sender, EventArgs e)
        {
            try
            {
                //prikazi nekretninu koja pripada kvartu
                ISession s = DataLayer.GetSession();

                // paramterizovani upit
                IQuery q = s.CreateQuery("select n.Kvart from Nekretnina as n "
                                        + " where n.Kvadratura >= :kvadratura and n.TipNekretnine= :ime");

                q.SetInt32("kvadratura", 20);
                q.SetString("ime", "STAN");

                IList<Kvart> kvartovi = q.List<Kvart>();

                foreach (Kvart k in kvartovi)
                {
                    MessageBox.Show(k.Naziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void ukupnaKvSvihNekretninaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("select sum(n.Kvadratura) from Nekretnina n ");

                // vraca samo jednu vrednost
                Int64 ukupnaKvadratura = q.UniqueResult<Int64>();

                MessageBox.Show(ukupnaKvadratura.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void prikaziBankRacuneVlasnikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Ucitavaju se podaci o vlasniku sa zadatim brojem

                Vlasnik v = s.Load<Vlasnik>(2);
                foreach (BankovniRacun n in v.BankovniRacuni)
                {
                    MessageBox.Show(n.ImeBanke + " " + n.BrojRacuna);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
