namespace StanNaDan;
public class EmailMapiranja : ClassMap<StanNaDan.Entiteti.Email>
{
    public EmailMapiranja()
    {
        Table("EMAIL");

        // kompozitni kljuc
        CompositeId(x => x.Id)
            .KeyReference(x => x.Vlasnik, "ID_VLASNIKA")
            .KeyReference(x => x.Email, "EMAIL");

        Map(x => x.EMAIL).Column("EMAIL");

        References(x => x.Vlasnik).Column("ID");
    }
}
