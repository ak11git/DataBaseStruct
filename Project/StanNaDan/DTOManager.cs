using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using StanNaDan.Entiteti;
using System.Windows.Forms;

using StanNaDan.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StanNaDan;



public class DTOManager
{
    #region Nekretnina

    public static List<NekretninaPregled> GetNekretninaPregled()
    {
        List<NekretninaPregled> nekretninaInfo = new List<NekretninaPregled>();

        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Nekretnina> nekretnine = from pr in session.Query<Nekretnina>() select pr;

            foreach (Nekretnina pk in nekretnine)
            {
                nekretninaInfo.Add(new NekretninaPregled(pk.ID, pk.TipNekretnine, pk.KucniBroj, pk.ImeUlice, pk.Kvadratura,
                                                           pk.BrojKupatila, pk.BrojTerasa, pk.BrojSoba, pk.Internet, pk.TV,

                                                           pk.Kuhinja, pk.Dimenzije, pk.TipKreveta));
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return nekretninaInfo;
    }
    public static NekretninaBasic GetNekretninaPregled(int nekretninaID)
    {
        NekretninaBasic nb = new NekretninaBasic();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Nekretnina n = session.Load<Nekretnina>(nekretninaID);

            Kvart k = session.Load<Kvart>(n.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(n.Vlasnik.Id);

            KvartBasic kb = new KvartBasic(k.Naziv, k.Zona);
            VlasnikBasic vb = new VlasnikBasic(v.Id, v.Ime, v.Prezime,
                                                v.Adresa, v.Mesto, v.Drzava
                                                );

            nb = new NekretninaBasic(n.ID, n.TipNekretnine, n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, vb, kb);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return nb;
    }
    public static KucaPregled GetKucaPregled(int nekretninaID)
    {
        KucaPregled nb = new KucaPregled();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Kuca n = session.Load<Kuca>(nekretninaID);



            nb = new KucaPregled(n.ID, n.TipNekretnine, n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, n.Spratnost, n.Dvoriste);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return nb;
    }
    public static StanPregled GetStanPregled(int nekretninaID)
    {
        StanPregled nb = new StanPregled();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Stan n = session.Load<Stan>(nekretninaID);



            nb = new StanPregled(n.ID, n.TipNekretnine, n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, n.Sprat, n.Lift);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return nb;
    }
    public static SobaPregled GetSobaPregled(int nekretninaID)
    {
        SobaPregled nb = new SobaPregled();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Soba n = session.Load<Soba>(nekretninaID);



            nb = new SobaPregled(n.ID, n.TipNekretnine, n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, n.Objekat);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return nb;
    }


    public static void AzurirajKuca(KucaBasic nb, int nID)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);
            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);




            Kuca n = session.Load<Kuca>(nb.ID);


            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Spratnost = nb.Spratnost;
            n.Dvoriste = nb.Dvoriste;

            n.Vlasnik = v;
            n.Kvart = k;
            session.SaveOrUpdate(n);
            session.Flush();


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void AzurirajStan(StanBasic nb, int nID)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);
            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);




            Stan n = session.Load<Stan>(nb.ID);


            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Sprat = nb.Sprat;
            n.Lift = nb.Lift;

            n.Vlasnik = v;
            n.Kvart = k;
            session.SaveOrUpdate(n);
            session.Flush();


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void AzurirajSobu(SobaBasic nb, int nID)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);
            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);




            Soba n = session.Load<Soba>(nb.ID);


            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Objekat = nb.Objekat;

            n.Vlasnik = v;
            n.Kvart = k;
            session.SaveOrUpdate(n);
            session.Flush();


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }

    public static void DodajKucu(KucaBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);



            Kuca n = new Kuca();
            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Spratnost = nb.Spratnost;
            n.Dvoriste = nb.Dvoriste;
            n.Vlasnik = v;
            n.Kvart = k;

            session.SaveOrUpdate(n);
            session.Flush();

            session.Flush();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void DodajStan(StanBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);



            Stan n = new Stan();
            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Sprat = nb.Sprat;
            n.Lift = nb.Lift;
            n.Vlasnik = v;
            n.Kvart = k;

            session.SaveOrUpdate(n);
            session.Flush();

            session.Flush();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void DodajSobu(SobaBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);

            Soba n = new Soba();
            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Objekat = nb.Objekat;
            n.Vlasnik = v;
            n.Kvart = k;

            session.SaveOrUpdate(n);
            session.Flush();

            session.Flush();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            session.Close();
        }
    }

    public static bool ObrisiNekretninu(int idNekretnine)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Nekretnina n = session.Load<Nekretnina>(idNekretnine);
            if (n == null)
                return false;
            var dodatnaOprema = from p in session.Query<DodatnaOprema>()
                                where p.Nekretnina.ID == idNekretnine
                                select p;

            var parkinzi = from p in session.Query<Parking>()
                           where p.Nekretnina.ID == idNekretnine
                           select p;

            var sajtovi = from p in session.Query<Sajtovi>()
                          where p.Nekretnina.ID == idNekretnine
                          select p;

            var najam = from p in session.Query<ImaNajam>()
                        where p.Nekretnina.ID == idNekretnine
                        select p;

            foreach (var oprema in dodatnaOprema)
            {
                session.Delete(oprema);
            }

            foreach (var parking in parkinzi)
            {
                session.Delete(parking);
            }

            foreach (var sajt in sajtovi)
            {
                session.Delete(sajt);
            }

            foreach (var najamItem in najam)
            {
                session.Delete(najamItem);
            }

            session.Delete(n);
            session.Flush();

            session.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        return true;
    }

    public static VlasnikPregled GetPregledVlasnikNekretnine(int idNekretnine)
    {
        ISession session = null;
        VlasnikPregled vp = null;

        try
        {
            session = DataLayer.GetSession();

            Nekretnina nekretnina = session.Load<Nekretnina>(idNekretnine);

            IEnumerable<Vlasnik> vlasnik = from o in session.Query<Vlasnik>()
                                           where o.Nekretnine.Contains(nekretnina)
                                           select o;
            Vlasnik vl = vlasnik.FirstOrDefault();
            if (vl == null)
                return null;


            vp = new VlasnikPregled(vl.Id, vl.Ime, vl.Prezime, vl.Adresa, vl.Mesto, vl.Drzava);
            session.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        return vp;
    }
    public static KvartPregled GetPregledKvartNekretnine(int idNekretnine)
    {
        ISession session = null;
        KvartPregled kp = null;

        try
        {
            session = DataLayer.GetSession();

            Nekretnina nekretnina = session.Load<Nekretnina>(idNekretnine);

            IEnumerable<Kvart> kvart = from o in session.Query<Kvart>()
                                       where o.Nekretnine.Contains(nekretnina)
                                       select o;
            Kvart kv = kvart.FirstOrDefault();
            if (kv == null)
                return null;


            kp = new KvartPregled(kv.Naziv, kv.Zona);
            session.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        return kp;
    }


    #endregion

    #region Vlasnik

    public static List<VlasnikPregled> GetVlasnikPregled()
    {
        ISession session = null;
        List<VlasnikPregled> vlasnikInfo = new List<VlasnikPregled>();

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Vlasnik> vlasnici = from v in session.Query<Vlasnik>() select v;

            foreach (Vlasnik v in vlasnici)
            {
                vlasnikInfo.Add(new VlasnikPregled(v.Id, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava));
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return vlasnikInfo;
    }
    public static VlasnikPregled GetVlasnikPregled(int vID)
    {
        ISession session = null;
        VlasnikPregled vlasnikinfo = new VlasnikPregled();

        try
        {
            session = DataLayer.GetSession();

            Vlasnik v = session.Load<Vlasnik>(vID);

            vlasnikinfo = new VlasnikPregled(v.Id, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return vlasnikinfo;
    }
    public static PravnoLicePregled GetPravnoLicePregled(int pID)
    {
        ISession session = null;
        PravnoLicePregled vlasnikinfo = new PravnoLicePregled();

        try
        {
            session = DataLayer.GetSession();

            PravnoLice v = session.Load<PravnoLice>(pID);

            vlasnikinfo = new PravnoLicePregled(v.Id, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava, v.PIB, v.Naziv);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return vlasnikinfo;
    }
    public static FizickoLicePregled GetFizickoLicePregled(int pID)
    {
        ISession session = null;
        FizickoLicePregled vlasnikinfo = new FizickoLicePregled();

        try
        {
            session = DataLayer.GetSession();

            FizickoLicePregled v = session.Load<FizickoLicePregled>(pID);

            vlasnikinfo = new FizickoLicePregled(v.Id, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava, v.ImeRoditelja, v.JMBG, v.DatumRodjenja);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return vlasnikinfo;
    }
    public static bool DodajPravnoLice(PravnoLiceBasic vb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            PravnoLice vl = new PravnoLice();


            vl.Id = vb.Id;
            vl.Ime = vb.Ime;
            vl.Prezime = vb.Prezime;
            vl.Adresa = vb.Adresa;
            vl.Mesto = vb.Mesto;
            vl.Drzava = vb.Drzava;
            vl.Naziv = vb.Naziv;
            vl.PIB = vb.PIB;

            session.SaveOrUpdate(vl);
            session.Flush();
            session.Update(vl);



            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return true;
    }
    public static bool DodajFizickoLice(FizickoLiceBasic vb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            FizickoLice vl = new FizickoLice();

            vl.Id = vb.Id;
            vl.Ime = vb.Ime;
            vl.Prezime = vb.Prezime;
            vl.Adresa = vb.Adresa;
            vl.Mesto = vb.Mesto;
            vl.Drzava = vb.Drzava;
            vl.ImeRoditelja = vb.ImeRoditelja;
            vl.DatumRodjenja = vb.DatumRodjenja;
            vl.JMBG = vb.JMBG;


            session.SaveOrUpdate(vl);
            session.Flush();


            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return true;
    }
    public static void AzurirajPravnoLice(PravnoLiceBasic vb, int vId)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            PravnoLice p = session.Load<PravnoLice>(vb.Id);
            if (p != null)
            {

                p.Adresa = vb.Adresa;
                p.PIB = vb.PIB;
                p.Naziv = vb.Naziv;
                p.Drzava = vb.Drzava;
                p.BankovniRacuni = (IList<BankovniRacun>?)vb.BankovniRacuni;
                p.BrojeviTelefona = (IList<BrojtTelefona>?)vb.BrojeviTelefona;
                p.Ime = vb.Ime;
                p.Prezime = vb.Prezime;
                p.Mesto = vb.Mesto;
                p.Emailovi = (IList<Email>?)vb.Emailovi;


            }

            session.SaveOrUpdate(p);
            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void AzurirajFizickoLice(FizickoLiceBasic vb, int vId)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            FizickoLice p = session.Load<FizickoLice>(vb.Id);
            if (p != null)
            {

                p.Adresa = vb.Adresa;
                p.ImeRoditelja = vb.ImeRoditelja;
                p.JMBG = vb.JMBG;
                p.DatumRodjenja = vb.DatumRodjenja;
                p.Drzava = vb.Drzava;
                p.BankovniRacuni = (IList<BankovniRacun>?)vb.BankovniRacuni;
                p.BrojeviTelefona = (IList<BrojtTelefona>?)vb.BrojeviTelefona;
                p.Ime = vb.Ime;
                p.Prezime = vb.Prezime;
                p.Mesto = vb.Mesto;
                p.Emailovi = (IList<Email>?)vb.Emailovi;


            }

            session.SaveOrUpdate(p);
            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void ObrisiPravnoLice(int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            //sad da li ovde ide za sve ili cascade all nama to omogucava??
            session.Delete(p);
            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void ObrisiFizickoLice(int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            //sad da li ovde ide za sve ili cascade all nama to omogucava??
            session.Delete(p);
            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }
    public static void DodajBankovniRacunPravnoLice(BankovniRacunBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            BankovniRacun banka = session.Load<BankovniRacun>(brb.ID);
            p.BankovniRacuni.Add(banka);
            banka.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(banka);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajBankovniRacunFizickoLice(BankovniRacunBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            BankovniRacun banka = session.Load<BankovniRacun>(brb.ID);
            p.BankovniRacuni.Add(banka);
            banka.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(banka);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajEmailPravnoLice(EmailBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            Email email = session.Load<Email>(brb.ID);
            p.Emailovi.Add(email);
            email.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(email);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajEmailFizickoLice(EmailBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            Email email = session.Load<Email>(brb.ID);
            p.Emailovi.Add(email);
            email.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(email);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajBrTelPravnoLice(BrojTelefonaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            BrojtTelefona brtel = session.Load<BrojtTelefona>(brb.ID);
            p.BrojeviTelefona.Add(brtel);
            brtel.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(brtel);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajBrTelFizickoLice(BrojTelefonaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            BrojtTelefona brtel = session.Load<BrojtTelefona>(brb.ID);
            p.BrojeviTelefona.Add(brtel);
            brtel.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(brtel);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajNekretninuPravnoLice(NekretninaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            Nekretnina nekretnina = session.Load<Nekretnina>(brb.ID);
            p.Nekretnine.Add(nekretnina);
            nekretnina.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(nekretnina);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajNekretninuFizickoLice(NekretninaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            Nekretnina nekretnina = session.Load<Nekretnina>(brb.ID);
            p.Nekretnine.Add(nekretnina);
            nekretnina.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(nekretnina);

            session.Flush();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

    }


    #endregion


    #region Poslovnica i Kvart
    public static void DodajPoslovnicu(PoslovnicaBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Poslovnica o = new Poslovnica();

            o.Adresa = p.Adresa;
            o.RadnoVreme= p.RadnoVreme;
            

            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }

    public static List<PoslovnicaPregled> GetPoslovnicaPregled()
    {
        ISession session = null;
        List<PoslovnicaPregled> poslovnicainfo = new List<PoslovnicaPregled>();

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Poslovnica> poslovnice = from v in session.Query<Poslovnica>() select v;

            foreach (Poslovnica v in poslovnice)
            {
                poslovnicainfo.Add(new PoslovnicaPregled(v.Adresa, v.RadnoVreme));
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return vlasnikInfo;
    }


    public static void DodajKvart(KvartBasic k)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Kvart o = new Kvart();

            o.Zona = k.Zona;
            o.Naziv = k.Naziv;


            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }
    }

    public static List<NekretninaPregled> VratiNekretnineKvarta(string naziv)
    {
        List<NekretninaPregled> vp = new List<NekretninaPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Nekretnina> nekretnine = from v in s.Query<Nekretnina>()
                                         where v.Kvart.Naziv == naziv
                                         select v;

            foreach (var n in nekretnine)
            {
                vp.Add(new NekretninaPregled(n.ID1, n.TipNekretnine1, n.KucniBroj1, n.ImeUlice1, n.Kvadratura1, n.BrojKupatila1, n.BrojTerasa1,
                    n.BrojSoba1, n.Internet1, n.T, n.Kuhinj1a, n.Dimenzije1, n.TipLreveta1));
                   
            }


            s.Close();

        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }

        return vp;
    }


    public static List<KvartPregled> GetKvartPregled()
    {
        ISession session = null;
        List<KvartPregled> kvartinfo = new List<KvartPregled>();

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Kvart> kvartovi = from v in session.Query<Kvart>() select v;

            foreach (Kvart v in kvartovi)
            {
                kvartinfo.Add(new KvartPregled(v.Naziv, v.Zona));
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return vlasnikInfo;
    }



    #endregion





    #region Najam

    //dodaj najam, da li moze ovako?

    public static void DodajNajam(NajamBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            // Učitavanje agenta iz baze podataka
            //Agent a = session.Load<Agent>(nb.AgentId);

            // Kreiranje instance najma
            Najam n = new Najam
            {
                ID = nb.ID,
                DatumOd = nb.DatumOd,
                DatumDo = nb.DatumDo,
                CenaPoDanu = nb.CenaPoDanu,
                BrojDana = nb.BrojDana,
                Popust = nb.Popust,
                Provizija = nb.Provizija,
                //Agent = a
            };

            // Spremanje najma u bazu podataka
            session.SaveOrUpdate(n);
            session.Flush();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static void DodajImaNajam(ImaNajamBasic inb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            // Učitavanje najma i nekretnine iz baze podataka
            Najam najam = session.Load<Najam>(inb.NajamId);
            Nekretnina nekretnina = session.Load<Nekretnina>(inb.NekretninaId);

            // Kreiranje instance ImaNajam
            ImaNajam inajam = new ImaNajam
            {
                Najam = najam,
                Nekretnina = nekretnina
            };

            // Spremanje ili ažuriranje ImaNajam u bazi podataka
            session.SaveOrUpdate(inajam);
            session.Flush();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static void ObrisiNajam(int najamId)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Najam najam = session.Load<Najam>(najamId);
            session.Delete(najam);
            session.Flush();

        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static void AzurirajNajam(NajamBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Najam najam = session.Load<Najam>(nb.ID);
            Agent agent = session.Load<Agent>(nb.AgentId);

            najam.DatumOd = nb.DatumOd;
            najam.DatumDo = nb.DatumDo;
            najam.CenaPoDanu = nb.CenaPoDanu;
            najam.BrojDana = nb.BrojDana;
            najam.Popust = nb.Popust;
            najam.Provizija = nb.Provizija;
            najam.Agent = agent;

            session.Update(najam);
            session.Flush();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static List<NajamPregled> GetNajamPregled()
    {
        ISession session = null;
        List<NajamPregled> najaminfo = new List<NajamPregled>();

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Najam> najmovi = from v in session.Query<Najam>() select v;

            foreach (Najam v in najmovi)
            {
                najaminfo.Add(new NajamPregled(v.ID, v.DatumDo, v.DatumDo, v.CenaPoDanu, v.BrojDana, v.Popust, v.Provizija));
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            session.Close();
        }

        return vlasnikInfo;
    }


    #endregion


    //prikazi sve nekretnine jednog kvarta

    //prikazi sve najmove jedne nekretnine

    //prikazi sve nekretnine jednog vlasnika

    //prikazi sve nekretnine koje imaju parkinge

    //angazuj spoljnog radnika

    //dodaj sefa


    //dodaj zaposlenog

    //dodaj agenta

    //neka agent angazuje spoljnog radnika za neki najam

    //


    //angazuj agenta za najam tj dodeli najmu agenta ?

    //dodaj kvartu poslovnicu

    //dodaj kvartu nekretninu

    //neke stvari za najam punooo



    //Prikazi Brojeve Racuna Vlasnika



    //Dodaj Kvart
    //Obrisi Kvart
    //Izmeni Kvart
    //Dodaj Kvart
    //Obrisi Kvart
    //Izmeni Kvart

    //Prikazi koji parking ima Nekretnina
    //Dodaj Parking
    //Obrisi Parking
    //Izmeni Parking

    //Prikazi Sajtove na kojima je oglasena Nekretnina??
    //Dodaj Sajt
    //Obrisi Sajt
    //Izmeni Sajt

    //Prikazi najmove Nekretnine
    //Dodaj Najam
    //Obrisi Najam
    //Izmeni Najam

    #region Sef 
    public static void dodajSefa(SefBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Sef o = new Sef();

            o.DatumPostavljanja = p.DatumPostavljanja;
            o.DatumZaposlenja = p.DatumZaposlenja;
            o.Ime=p.Ime;
            o.JMBG=p.JMBG;


            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static SefBasic azurirajSefa(SefBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Sef o = s.Load<Sef>(p.JMBG);
            o.DatumPostavljanja=p.DatumPostavljanja;
            o.DatumZaposlenja=p.DatumZaposlenja;
            o.Ime=p.Ime;
            

           
            s.Update(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return p;
    }

    public static SefBasic vratiSefa(string JMBG)
    {
        SefBasic pb = new SefBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Sef o = s.Load<Sef>(JMBG);
            pb = new SefBasic(o.Ime, o.DatumZaposlenja, o.DatumPostavljanja);

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }




    #endregion


    #region Agent

    public static void dodajAgenta(AgentBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Agent o = new Agent();

            o.StrucnaSprema=p.StrucnaSprema;


        
            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static AgentBasic azurirajAgenta(AgentBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Agent o = s.Load<Agent>(p.JMBG);
            o.StrucnaSprema = p.StrucnaSprema;



            s.Update(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return p;
    }

    public static AgentBasic vratiAgenta(string JMBG)
    {
        AgentBasic pb = new AgentBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Agent o = s.Load<Agent>(JMBG);
            pb = new AgentBasic(o.StrucnaSprema);

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }



    #endregion

    #region SpoljniRadnik

    public static void dodajSpoljnogRadnika(SpoljniRadnikBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            SpoljniRadnik o = new SpoljniRadnik();

            o.DatumAngazovanja = p.DatumAngazovanja;
            o.Procenat=p.Procenat;
            o.BrojTelefona=p.BrojTelefona;
            o.Ime=p.Ime;
           

            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static SpoljniRadnikBasic azurirajRadnika(SpoljniRadnikBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            SpoljniRadnik o = s.Load<SpoljniRadnik>(p.Id);
            o.DatumAngazovanja = p.DatumAngazovanja;
            o.Procenat = p.Procenat;
            o.BrojTelefona = p.BrojTelefona;
            o.Ime = p.Ime;




            s.Update(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return p;
    }

    public static SpoljniRadnikBasic vratiRadnika(int id)
    {
        AgentBasic pb = new AgentBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            SpoljniRadnik o = s.Load<SpoljniRadnik>(id);
            pb = new SpoljniRadnik(o.Ime, o.BrojTelefona, o.DatumAngazovanja, o.Procenat);

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }



    #endregion



    
    #region Parking

    public static void dodajParking(ParkingBasic p, int idnekretnine)
    {
        try
        {
            ISession s = DataLayer.GetSession();
            Nekretnina nekretnina = session.Load<Nekretnina>(idnekretnine);

            Parking o = new Parking();

            o.Cena=p.Cena;
            o.Javni=p.Javni;
            o.Nekretnina = nekretnina;
            

            


            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static ParkingBasic azurirajParking(ParkingBasic p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            ParkingBasic o = s.Load<ParkingBasic>(p.ID);
            o.Cena = p.Cena;
            o.Javni = p.Javni;
          



            s.Update(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return p;
    }

    public static ParkingBasic vratiParking(int id)
    {
        AgentBasic pb = new AgentBasic();
        try
        {
            ISession s = DataLayer.GetSession();

            Parking o = s.Load<Parking>(id);
            pb = new Parking(o.ID, o.Javni, o.Cena, o.Nekretnina);
            
            s.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }



    #endregion
}


