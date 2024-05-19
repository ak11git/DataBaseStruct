namespace StanNaDan.Entiteti;

public class Najam
{
    public virtual int ID { get; set; }

    public virtual DateTime DatumOd { get; set; }

    public virtual DateTime DatumDo { get; set; }

    public virtual decimal CenaPoDanu { get; set; }

    public virtual int BrojDana { get; set; } // da li treba??

    public virtual decimal Popust { get; set; }

    public virtual decimal Provizija { get; set; }

    public Agent Agent { get; set; }

    public virtual IList<ImaNajam> ListaNekretnina { get; set; } //malo nelogicno | sad jeste

    public Najam()
    {
        ListaNekretnina = new List<ImaNajam>();
    }
}