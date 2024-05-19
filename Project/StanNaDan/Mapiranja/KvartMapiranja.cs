
namespace StanNaDan;

public class KvartMapiranja : ClassMap<StanNaDan.Entiteti.Kvart>
{
    public KvartMapiranja()
    {
        Table("KVART");

        Id(x => x.Naziv).Column("NAZIV").GeneratedBy.Assigned();

        Map(x => x.Zona, "ZONA");

        //strani kljuc n to 1
        References(x => x.Poslovnica).Column("ADRESA");


        HasMany(x => x.Nekretnine).KeyColumn("NAZIV_KVARTA").LazyLoad().Cascade.All().Inverse();
    }
}
