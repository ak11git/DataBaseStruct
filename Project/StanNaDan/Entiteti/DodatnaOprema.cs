
namespace StanNaDan.Entiteti;

public class DodatnaOprema
{
    public virtual DodatnaOpremaId kljucId { get; set; }

    public virtual int ID { get; set; }
    public virtual string Tip { get; set; }

    public virtual decimal Cena { get; set; }

    public virtual Nekretnina Nekretnina { get; set; }

    public DodatnaOprema()
    {
        kljucId = new DodatnaOpremaId();
    }

}