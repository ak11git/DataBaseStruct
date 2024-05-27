//using NHibernate;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using NHibernate.Linq;
//using StanNaDan.Entiteti;
//using System.Windows.Forms;

//using StanNaDan.Entiteti;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace StanNaDan;

//#region Nekretnina
//public class NekretninaBasic
//{

//}




//#endregion

//#region Poslovnica

//#endregion


//#region Kvart

//#endregion


//#region Vlasnik

//#endregion


//#region BankovniRacun

//#endregion


//#region SpoljniSaradnik

//#endregion

//#region Zaposlen

//#endregion

//#region Sef

//#endregion

//#region Agent

//#endregion


//#region Najam

//#endregion

//#region DodatnaOprema

//#endregion

//#region Parking

//#endregion 

//#region Angazuje

//#endregion

//#region ImaNajam

//#endregion

//#region Sajtovi

//#endregion


//#region Email

//#endregion


//#region BrojTelefona

//#endregion





////namespace StanNaDan
////{
////    public class DTOManager
////    {
////        //sve crud operacije za svaku klasu

////        public static Nekretnina azurirajNekretninu(Nekretnina n)
////        {
////            try
////            {
////                ISession s = DataLayer.GetSession();

////                StanNaDan.Entiteti.Nekretnina o = s.Load<StanNaDan.Entiteti.Nekretnina>(n.ID);
////                o.ImeUlice = n.ImeUlice;
////                o.Internet=n.Internet ;
////                o.KucniBroj = n.KucniBroj;
////                o.Lift = n.Lift;
////                o.Kuhinja = n.Kuhinja;
////                o.Sajtovi = n.Sajtovi;
////                o.Kvadratura = n.Kvadratura;
////                o.BrojKupatila = n.BrojKupatila;
////                o.BrojSoba=n.BrojSoba;
////                o.BrojTerasa = n.BrojTerasa;
////                o.Dimenzije = n.Dimenzije;
////                o.Dvoriste = n.Dvoriste;
////                o.DodatnaOprema=n.DodatnaOprema;



                
                

////                s.Update(o);
////                s.Flush();

////                s.Close();
////            }
////            catch (Exception ec)
////            {
////                //handle exceptions
////            }

////            return n;
////        }





////    }
