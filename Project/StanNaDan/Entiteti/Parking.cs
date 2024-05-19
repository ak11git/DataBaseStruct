
namespace StanNaDan.Entiteti;

public class Parking { 

    public virtual ParkingId kljucId { get; set; }

    public virtual int ID { get; set; }

    public virtual decimal Cena { get; set; }

    public virtual int Javni { get; set; } // 0 ili 1

    public virtual Nekretnina Nekretnina { get; set; }

    public Parking()
    {
        kljucId = new ParkingId();
    }
}