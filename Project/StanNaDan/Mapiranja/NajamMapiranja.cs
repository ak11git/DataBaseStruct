
namespace StanNaDan;

public class NajamMapiranja : ClassMap<StanNaDan.Entiteti.Najam>
{

    public NajamMapiranja()
    {
        Table("NAJAM");


        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.DatumDo, "DATUM_DO");
        Map(x => x.DatumOd, "DATUM_OD");
        Map(x => x.BrojDana, "BROJ_DANA");
        Map(x => x.CenaPoDanu, "CENA_PO_DANU");
        Map(x => x.Popust, "POPUST");
        Map(x => x.Provizija, "PROVIZIJA");

        References(x => x.Agent).Column("JMBG").LazyLoad();
        HasMany(x => x.ListaNekretnina).KeyColumn("ID_NAJMA").LazyLoad().Cascade.All().Inverse();

    }
}
