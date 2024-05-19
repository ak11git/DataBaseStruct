using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using StanNaDan.Entiteti;
using System.Windows.Forms;

namespace StanNaDan
{
    public class DTOManager
    {
        //sve crud operacije za svaku klasu

        public static Nekretnina azurirajNekretninu(Nekretnina n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDan.Entiteti.Nekretnina o = s.Load<StanNaDan.Entiteti.Nekretnina>(n.ID);
                o.ImeUlice = n.ImeUlice;
                o.Internet=n.Internet ;
                o.KucniBroj = n.KucniBroj;
                o.Lift = n.Lift;
                o.Kuhinja = n.Kuhinja;
                o.Kvadratura = n.Kvadratura;
                o.BrojKupatila = n.BrojKupatila;
                o.BrojSoba=n.BrojSoba;
                o.BrojTerasa = n.BrojTerasa;
                o.Dimenzije = n.Dimenzije;
                o.Dvoriste = n.Dvoriste;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return n;
        }
    }
}