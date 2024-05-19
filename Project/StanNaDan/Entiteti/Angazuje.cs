
namespace StanNaDan.Entiteti;
public class Angazuje
{
    public virtual AngazujeID Id { get; set; }
    public virtual Agent Agent { get; set; }
    public virtual SpoljniRadnik SpoljniRadnik { get; set; }

    public Angazuje()
    {
        Id = new AngazujeID();
    }

}