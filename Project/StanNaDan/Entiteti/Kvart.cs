
namespace StanNaDan.Entiteti;

public class Kvart
{
  
    public virtual string Naziv { get; set; }
    public virtual string Zona { get; set; }

    public virtual Poslovnica Poslovnica { get; set; }

    public virtual IList<Nekretnina> Nekretnine { get; set; }

    public Kvart()
    {
        Nekretnine = new List<Nekretnina>();
    }

}

