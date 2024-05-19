
namespace StanNaDan;

public class AgentMapiranja: SubclassMap<StanNaDan.Entiteti.Agent>
{
    public AgentMapiranja()
    {
        Table("AGENT"); //FOREIGN KEY(JMBG) REFERENCES ZAPOSLEN(JMBG) && JMBG VARCHAR(13) PRIMARY KEY,

        KeyColumn("JMBG");

        Map(x => x.StrucnaSprema, "STRUCNA_SPREMA");

        // ne treba za strani kljuc jer nasledjuje...

        HasMany(x => x.Angazovanja).KeyColumn("JMBG_AGENTA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Najmovi).KeyColumn("JMBG_AGENTA").LazyLoad().Cascade.All().Inverse();
    }

}
