
namespace StanNaDan;

public class BankovniRacunMapiranja : ClassMap<StanNaDan.Entiteti.BankovniRacun>
{

    public BankovniRacunMapiranja()
    {
        Table("BANKOVNI_RACUN");

        // Kompozitni kljuc
        CompositeId(x => x.Id)
            .KeyReference(x => x.BankovniRacun, "BROJ_RACUNA")
            .KeyReference(x => x.BankovniRacun, "IME_BANKE")
            .KeyReference(x => x.Vlasnik, "ID_VLASNIKA");

        References(x => x.Vlasnik).Column("ID").Not.Insert().Not.Update();

        //Map(x => x.BrojRacuna, "BROJ_RACUNA");
        //Map(x => x.ImeBanke, "IME_BANKE");
    }
}
