
namespace StanNaDan;
public class DodatnaOpremaMapiranja : ClassMap<StanNaDan.Entiteti.DodatnaOprema>
{
    public DodatnaOpremaMapiranja()
    {
        Table("DODATNA_OPREMA");

        // Kompozitni kljuc
        CompositeId(x => x.kljucId)
            .KeyReference(x => x.DodatnaOprema, "ID_OPREME")
            .KeyReference(x => x.Nekretnina, "ID_NEKRETNINE");

        Map(x => x.Tip, "TIP");
        Map(x => x.Cena, "CENA");

        References(x => x.Nekretnina).Column("ID").Not.Nullable();

    }
}
