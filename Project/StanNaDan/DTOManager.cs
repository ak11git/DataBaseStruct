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
                                                v.Adresa, v.Mesto, v.Drzava,
                                                v.DatumRodjenja, v.JMBG,
                                                v.Naziv, v.PIB);

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
    public static void DodajNekretninu(NekretninaBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);

            DodatnaOprema dod = (from p in session.Query<DodatnaOprema>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Parking pk = (from p in session.Query<Parking>()
                          where p.Nekretnina.ID == nb.ID
                          select p).FirstOrDefault();

            Sajtovi sajt = (from p in session.Query<Sajtovi>()
                            where p.Nekretnina.ID == nb.ID
                            select p).FirstOrDefault();

            ImaNajam imanajam = (from p in session.Query<ImaNajam>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Nekretnina n = new Nekretnina();
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
            n.Sprat = nb.Sprat;
            n.Lift = nb.Lift;
            n.Vlasnik = v;
            n.Kvart = k;

            session.SaveOrUpdate(n);
            session.Flush();
            pk.Nekretnina = n;
            dod.Nekretnina = n;
            sajt.Nekretnina = n;
            imanajam.Nekretnina = n;

            session.Update(pk);
            session.Update(dod);
            session.Update(sajt);
            session.Update(imanajam);
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

    public static void AzurirajNekretninu(NekretninaBasic nb, int nID)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);
            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);



            Nekretnina n = session.Load<Nekretnina>(nb.ID);
            Kuca kuca = session.Load<Kuca>(nb.ID);
            Stan stan = session.Load<Stan>(nb.ID);
            Soba soba = session.Load<Soba>(nb.ID);

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
            n.Sprat = nb.Sprat;
            n.Lift = nb.Lift;
            n.Vlasnik = v;
            n.Kvart = k;
            if (n is Kuca kuca)
            {
                kuca.Spratnost = nb.Spratnost;
                kuca.Dvoriste = nb.Dvoriste;
            }
            else if (n.TipNekretnine == "STAN")
            {
                stan.Sprat = nb.Sprat;
                stan.Lift = nb.Lift;
            }

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

            DodatnaOprema dod = (from p in session.Query<DodatnaOprema>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Parking pk = (from p in session.Query<Parking>()
                          where p.Nekretnina.ID == nb.ID
                          select p).FirstOrDefault();

            Sajtovi sajt = (from p in session.Query<Sajtovi>()
                            where p.Nekretnina.ID == nb.ID
                            select p).FirstOrDefault();

            ImaNajam imanajam = (from p in session.Query<ImaNajam>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Nekretnina n = new Nekretnina();
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
            pk.Nekretnina = n;
            dod.Nekretnina = n;
            sajt.Nekretnina = n;
            imanajam.Nekretnina = n;

            session.Update(pk);
            session.Update(dod);
            session.Update(sajt);
            session.Update(imanajam);
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

            DodatnaOprema dod = (from p in session.Query<DodatnaOprema>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Parking pk = (from p in session.Query<Parking>()
                          where p.Nekretnina.ID == nb.ID
                          select p).FirstOrDefault();

            Sajtovi sajt = (from p in session.Query<Sajtovi>()
                            where p.Nekretnina.ID == nb.ID
                            select p).FirstOrDefault();

            ImaNajam imanajam = (from p in session.Query<ImaNajam>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Nekretnina n = new Nekretnina();
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
            pk.Nekretnina = n;
            dod.Nekretnina = n;
            sajt.Nekretnina = n;
            imanajam.Nekretnina = n;

            session.Update(pk);
            session.Update(dod);
            session.Update(sajt);
            session.Update(imanajam);
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

            DodatnaOprema dod = (from p in session.Query<DodatnaOprema>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Parking pk = (from p in session.Query<Parking>()
                          where p.Nekretnina.ID == nb.ID
                          select p).FirstOrDefault();

            Sajtovi sajt = (from p in session.Query<Sajtovi>()
                            where p.Nekretnina.ID == nb.ID
                            select p).FirstOrDefault();

            ImaNajam imanajam = (from p in session.Query<ImaNajam>()
                                 where p.Nekretnina.ID == nb.ID
                                 select p).FirstOrDefault();

            Nekretnina n = new Nekretnina();
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
            //n.Objekat = nb.Objekat;
            n.Vlasnik = v;
            n.Kvart = k;

            session.SaveOrUpdate(n);
            session.Flush();
            pk.Nekretnina = n;
            dod.Nekretnina = n;
            sajt.Nekretnina = n;
            imanajam.Nekretnina = n;

            session.Update(pk);
            session.Update(dod);
            session.Update(sajt);
            session.Update(imanajam);
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


            vp = new VlasnikPregled(vl.Id, vl.Ime, vl.Prezime, vl.Adresa, vl.Mesto, vl.Drzava,
                                    vl.DatumRodjenja, vl.JMBG, vl.Naziv, vl.PIB);
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
                vlasnikInfo.Add(new VlasnikPregled(v.Id, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava, v.DatumRodjenja,
                                                    v.JMBG, v.Naziv, v.PIB));
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

            vlasnikinfo = new VlasnikPregled(v.Id, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava, v.DatumRodjenja,
                                                    v.JMBG, v.Naziv, v.PIB);
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
    public static bool DodajVlasnika(VlasnikBasic vb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Vlasnik vl = new Vlasnik();

            BankovniRacun bankovni = (from v in session.Query<BankovniRacun>()
                                      where v.Vlasnik.Id == vb.Id
                                      select v).FirstOrDefault();

            Email e = (from v in session.Query<Email>()
                       where v.Vlasnik.Id == vb.Id
                       select v).FirstOrDefault();

            BrojtTelefona br = (from v in session.Query<BrojtTelefona>()
                                where v.Vlasnik.Id == vb.Id
                                select v).FirstOrDefault();
            Nekretnina n = (from v in session.Query<Nekretnina>()
                            where v.Vlasnik.Id == vb.Id
                            select v).FirstOrDefault();

            vl.Id = vb.Id;
            vl.Ime = vb.Ime;
            vl.Prezime = vb.Prezime;
            vl.Adresa = vb.Adresa;
            vl.Mesto = vb.Mesto;
            vl.Drzava = vb.Drzava;
            vl.ImeRoditelja = vb.ImeRoditelja;
            vl.DatumRodjenja = vb.DatumRodjenja;
            vl.JMBG = vb.JMBG;
            vl.Naziv = vb.Naziv;
            vl.PIB = vb.PIB;
            vl.BankovniRacuni.Add(bankovni);
            vl.BrojeviTelefona.Add(br);
            vl.Emailovi.Add(e);
            vl.Nekretnine.Add(n);
            n.Vlasnik = vl;
            bankovni.Vlasnik = vl;
            br.Vlasnik = vl;
            e.Vlasnik = vl;
            session.SaveOrUpdate(vl);
            session.Flush();
            session.Update(n);
            session.Update(bankovni);
            session.Update(br);
            session.Update(e);


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
    public static void AzurirajVlasnika(VlasnikBasic vb, int vId)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Operater op = session.Load<Operater>(pkb.IdOperatera);

            Parking_Mesto staroPM = session.Load<Parking_Mesto>(pkb.IdParkingMesta);
            Parking_Mesto novoPM = session.Load<Parking_Mesto>(pmId);

            PretplatnaKarta pk = session.Load<PretplatnaKarta>(pkb.IdKarte);

            pk.DatumOd = pkb.DatumOd;
            pk.DatumDo = pkb.DatumDo;
            pk.ParkingMesto = novoPM;
            pk.Operater = op;

            session.SaveOrUpdate(pk);
            session.Flush();

            if (staroPM.ID != novoPM.ID)
            {
                staroPM.Status = 'S';
                staroPM.Karta = null;
                session.SaveOrUpdate(staroPM);
                session.Flush();
            }

            novoPM.Status = 'Z';
            novoPM.Karta = pk;
            session.SaveOrUpdate(novoPM);
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

    //kvart pa na dole





}


