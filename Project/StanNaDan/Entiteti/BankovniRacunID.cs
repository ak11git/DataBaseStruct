namespace StanNaDan.Entiteti
{
    public class BankovniRacunId
    {
        public virtual BankovniRacun BankovniRacun { get; set; }
        public virtual Vlasnik Vlasnik { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(BankovniRacunId))
                return false;

            BankovniRacunId recievedObject = (BankovniRacunId)obj;

            if ((BankovniRacun.BrojRacuna == recievedObject.BankovniRacun.BrojRacuna) &&
                (Vlasnik.Id == recievedObject.Vlasnik.Id) &&
                (BankovniRacun.ImeBanke == recievedObject.BankovniRacun.ImeBanke))
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
