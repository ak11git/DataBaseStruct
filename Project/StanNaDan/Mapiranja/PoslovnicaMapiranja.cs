
namespace StanNaDan;

public class PoslovnicaMapiranja : ClassMap<StanNaDan.Entiteti.Poslovnica>
{
    public PoslovnicaMapiranja() {

        Table("POSLOVNICA");

        Id(x => x.Adresa).Column("ADRESA").GeneratedBy.Assigned();

        Map(x => x.RadnoVreme, "RADNO_VREME");

        HasMany(x => x.Kvartovi).KeyColumn("ADRESA_POSLOVNICE").LazyLoad().Cascade.All().Inverse();

        HasMany(x => x.Zaposleni).KeyColumn("ADRESA_POSLOVNICE").LazyLoad().Cascade.All().Inverse();

    }

}
