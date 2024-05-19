
namespace StanNaDan;
public class SajtoviMapiranja : ClassMap<StanNaDan.Entiteti.Sajtovi>
{
    public SajtoviMapiranja()
    {
        Table("SAJTOVI");

        // kompozitni kljuc
        CompositeId(x => x.Id)
            .KeyReference(x => x.Nekretnina, "ID_NEKRETNINA")
            .KeyReference(x => x.Sajtovi, "SAJTOVI");

        //Map(x => x.Sajt, "SAJT");

        References(x => x.Nekretnina).Column("ID").Not.Nullable();

    }
}