namespace StanNaDan.Entiteti
{
    public class ParkingId
    {
        public virtual Parking Parking { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ParkingId))
                return false;

            ParkingId recievedObject = (ParkingId)obj;

            if ((Parking.ID == recievedObject.Parking.ID) &&
                (Nekretnina.ID == recievedObject.Nekretnina.ID))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
