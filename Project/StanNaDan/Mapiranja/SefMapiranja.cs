namespace StanNaDan;
public class SefMapiranja : SubclassMap<StanNaDan.Entiteti.Sef>
{
    public SefMapiranja()
    {
        Table("SEF");

        KeyColumn("JMBG");

        Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");

    }
}