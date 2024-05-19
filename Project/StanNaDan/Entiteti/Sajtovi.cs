namespace StanNaDan.Entiteti;

public class Sajtovi
{
    public virtual SajtoviId Id { get; set; }
    public virtual Nekretnina Nekretnina { get; set; }
    public virtual string Sajt { get; set; }

    public Sajtovi()
    {
        Id = new SajtoviId();
    }

}