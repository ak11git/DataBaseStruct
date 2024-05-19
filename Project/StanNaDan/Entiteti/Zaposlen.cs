
namespace StanNaDan.Entiteti;

public class Zaposlen
{
    public virtual string Ime { get; set; } 

    public virtual string JMBG { get; set; }

    public Poslovnica Poslovnica { get; set; }

    public virtual DateTime DatumZaposlenja { get; set; }

}