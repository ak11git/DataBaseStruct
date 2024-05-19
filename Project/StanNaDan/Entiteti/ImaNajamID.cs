namespace StanNaDan.Entiteti
{
    public class ImaNajamId
    {
        public virtual Najam Najam { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ImaNajamId))
                return false;

            ImaNajamId recievedObject = (ImaNajamId)obj;

            if ((Najam.ID == recievedObject.Najam.ID) &&
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
