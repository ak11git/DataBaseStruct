
namespace StanNaDan.Entiteti;

public class Agent: Zaposlen
{
 

    public virtual string StrucnaSprema { get; set; }

    public virtual IList<Angazuje> Angazovanja { get; set; }
    public virtual IList<Najam> Najmovi { get; set; }

    public Agent()
    {
        Angazovanja = new List<Angazuje>();
        Najmovi = new List<Najam>();

    }

}