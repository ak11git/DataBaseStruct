
namespace StanNaDan;
public class ParkingMapiranja : ClassMap<StanNaDan.Entiteti.Parking>
{
    public ParkingMapiranja()
    {
        Table("PARKING");

        // kompozitni kljuc
        CompositeId(x => x.kljucId)
            .KeyReference(x => x.Parking, "ID_PARKINGA")
            .KeyReference(x => x.Nekretnina, "ID_NEKRETNINE");

        Map(x => x.Cena, "CENA");
        Map(x => x.Javni, "JAVNI");

        References(x => x.Nekretnina).Column("ID").Not.Nullable();
    }
}
