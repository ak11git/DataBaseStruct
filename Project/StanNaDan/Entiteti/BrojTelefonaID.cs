namespace StanNaDan.Entiteti
{
    public class BrojTelefonaID
    {
        public virtual BrojTelefona brojTelefona { get; set; }
        public virtual Vlasnik Vlasnik { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(BrojTelefonaID))
                return false;

            BrojTelefonaID recievedObject = (BrojTelefonaID)obj;

            if ((brojTelefona.Broj == recievedObject.brojTelefona.Broj) &&
                (Vlasnik.Id == recievedObject.Vlasnik.Id))
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
