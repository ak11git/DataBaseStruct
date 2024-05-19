namespace StanNaDan.Entiteti;

public class Vlasnik
{
    public virtual int Id { get; set; }
    public virtual string Ime { get; set; } // ovo je LIME
    public virtual string Prezime { get; set; }

    public virtual string Adresa { get; set; }

    public virtual string Mesto { get; set; }

    public virtual string Drzava { get; set; }

    public virtual string ImeRoditelja { get; set; }
    public virtual DateTime DatumRodjenja { get; set; }

    public virtual string JMBG { get; set; }

    public virtual string Naziv { get; set; }

    public virtual string PIB { get; set; }

    public virtual IList<BankovniRacun>? BankovniRacuni { get; set; }

    public virtual IList<BrojTelefona>? BrojeviTelefona { get; set; }

    public virtual IList<Email>? Emailovi { get; set; }

    public virtual IList<Nekretnina>? Nekretnine { get; set; }


    public Vlasnik()
    {
        BankovniRacuni = new List<BankovniRacun>();

        BrojeviTelefona = new List<BrojTelefona>();

        Emailovi = new List<Email>();

        Nekretnine = new List<Nekretnina>();
    }
}


public class FizickoLice : Vlasnik
{
}

public class PravnoLice : Vlasnik
{
}


