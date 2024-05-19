
namespace StanNaDan.Entiteti;

public class BankovniRacun
{
    public virtual BankovniRacunId Id { get; set; }
    public virtual string BrojRacuna { get; set; }

    public virtual string ImeBanke { get; set; }
    
    public virtual Vlasnik Vlasnik { get; set; }

    public BankovniRacun ()
    {
        Id = new BankovniRacunId();
    }
    
}