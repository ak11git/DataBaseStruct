
namespace StanNaDan;

public class AngazujeMapiranja : ClassMap<StanNaDan.Entiteti.Angazuje>
{
    public AngazujeMapiranja()
    {
        Table("ANGAZUJE");

        CompositeId(x => x.Id)
                 .KeyReference(x => x.SpoljniRadnik, "ID_SPOLJNOG_RADNIKA")
                 .KeyReference(x => x.Agent, "JMBG_AGENTA");

        References(x => x.SpoljniRadnik).Column("ID").Not.Insert().Not.Update();
        References(x => x.Agent).Column("JMBG").Not.Insert().Not.Update();
    }
}
