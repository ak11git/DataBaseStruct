namespace StanNaDan.Entiteti
{
    public class EmailId
    {
        public virtual Email Email { get; set; }
        public virtual Vlasnik Vlasnik { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(EmailId))
                return false;

            EmailId recievedObject = (EmailId)obj;

            if ((Email.EMAIL == recievedObject.Email.EMAIL) &&
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
