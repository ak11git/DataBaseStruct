
namespace StanNaDan;

public class ZaposlenMapiranja : ClassMap<StanNaDan.Entiteti.Zaposlen>
{

    public ZaposlenMapiranja()
    {
        Table("ZAPOSLEN");

        Id(x => x.JMBG).Column("JMBG").GeneratedBy.Assigned();

        Map(x => x.Ime, "IME");
        Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLENJA");

        References(x => x.Poslovnica).Column("ADRESA").LazyLoad();
    }
}
