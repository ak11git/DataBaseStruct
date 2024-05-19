namespace StanNaDan.Entiteti
{
    public class DodatnaOpremaId
    {
        public virtual DodatnaOprema DodatnaOprema { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(DodatnaOpremaId))
                return false;

            DodatnaOpremaId recievedObject = (DodatnaOpremaId)obj;

            if ((DodatnaOprema.ID == recievedObject.DodatnaOprema.ID) &&
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
