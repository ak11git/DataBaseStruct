
namespace StanNaDan;

public class ImaNajamMapiranja : ClassMap<StanNaDan.Entiteti.ImaNajam>
{
    public ImaNajamMapiranja()
    {
        Table("IMA_NAJAM");

        CompositeId(x => x.Id)
            .KeyReference(x => x.Najam, "ID_NAJMA")
            .KeyReference(x => x.Nekretnina, "ID_NEKRETNINE");

        References(x => x.Najam).Column("ID").Not.Insert().Not.Update();
        References(x => x.Nekretnina).Column("ID").Not.Insert().Not.Update();

    }
}
