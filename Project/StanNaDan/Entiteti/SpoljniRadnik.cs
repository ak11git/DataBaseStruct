
namespace StanNaDan.Entiteti;

public class SpoljniRadnik { 
    public virtual int Id { get; set; } 

    public virtual string BrojTelefona { get; set; }

    public virtual string Ime { get; set; }

    public virtual DateTime DatumAngazovanja { get; set; }

    public virtual decimal Procenat { get; set; }

    public virtual IList<Angazuje> Angazovanja { get; set; }

    public SpoljniRadnik()
    {
        Angazovanja = new List<Angazuje>();
    }
}
