namespace StanNaDan.Entiteti
{
    public class SajtoviId
    {
        public virtual Sajtovi Sajtovi { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(SajtoviId))
                return false;

            SajtoviId recievedObject = (SajtoviId)obj;

            if ((Sajtovi.Sajt == recievedObject.Sajtovi.Sajt) &&
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

