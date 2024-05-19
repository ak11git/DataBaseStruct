
namespace StanNaDan;

public class BrojTelefonaMapiranja : ClassMap<StanNaDan.Entiteti.BrojTelefona>
{

    public BrojTelefonaMapiranja()
    {
        Table("BROJ_TELEFONA");

        // kompozitni kljuc
        CompositeId(x => x.Id)
            .KeyReference(x => x.Vlasnik, "ID_VLASNIKA")
            .KeyReference(x => x.brojTelefona, "BROJ");

        //Map(x => x.Broj).Column("BROJ");

        References(x => x.Vlasnik).Column("ID");
    }
}
