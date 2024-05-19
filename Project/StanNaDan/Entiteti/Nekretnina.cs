
namespace StanNaDan.Entiteti;

public class Nekretnina { 
    public virtual int  ID { get; set; }
    public virtual string TipNekretnine { get; set; }

    public virtual int KucniBroj { get; set; }

    public virtual string ImeUlice { get; set; }
    public virtual decimal Kvadratura { get; set; }

    public virtual int BrojKupatila  { get; set; }
    public virtual int BrojTerasa { get; set; }
    public virtual int BrojSoba { get; set; }
    public virtual int Internet { get; set; } // 0 ili 1
    public virtual int TV { get; set; } // 0 ili 1

    public virtual int Kuhinja { get; set; } // 0 ili 1
    public virtual string Dimenzije { get; set; }

    public virtual string TipKreveta { get; set; }

    public virtual int Spratnost { get; set; }

    public virtual int Dvoriste { get; set; } // 0 ili 1

    public virtual int Sprat { get; set; } // 0 ili 1

    public virtual int Lift  { get; set; } // 0 ili 1

    public virtual string Objekat { get; set; }

    //3 reference

    public virtual Vlasnik Vlasnik { get; set; }

    public virtual Kvart Kvart { get; set; }

    public virtual IList<ImaNajam> ListaNajmova { get; set; }
    public virtual IList<DodatnaOprema> ListaDodatneOpreme { get; set; }
    public virtual IList<Parking> ListaParkinga { get; set; }
    public virtual IList<Sajtovi> ListaSajtova { get; set; }


    public Nekretnina()
    {
        ListaNajmova = new List<ImaNajam>();
        ListaDodatneOpreme = new List<DodatnaOprema>();
        ListaParkinga = new List<Parking>();
        ListaSajtova = new List<Sajtovi>();
    }

}

public class Soba : Nekretnina
{
}

public class Kuca : Nekretnina
{
}

public class Stan : Nekretnina
{
}
