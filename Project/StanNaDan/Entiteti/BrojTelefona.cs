
namespace StanNaDan.Entiteti;

public class BrojTelefona
{
    public virtual BrojTelefonaID Id { get; set; }

    public virtual Vlasnik Vlasnik { get; set; }

    public virtual string Broj { get; set; }

    public BrojTelefona()
    {
        Id = new BrojTelefonaID();
    }

}