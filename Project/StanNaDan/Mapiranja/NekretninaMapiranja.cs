namespace StanNaDan.Mapiranja
{
    class NekretninaMapiranja : ClassMap<Nekretnina>
    {
        public NekretninaMapiranja()
        {

            //Mapiranje tabele
            Table("NEKRETNINA"); 

            //mapiranje primarnog kljuca
            // Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity().UnsavedValue(-1);
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
         
            Map(x => x.KucniBroj, "KUCNI_BROJ");
            Map(x => x.ImeUlice, "IME_ULICE");
            Map(x => x.Kvadratura, "KVADRATURA");
            Map(x => x.BrojKupatila, "BROJ_KUPATILA");
            Map(x => x.BrojTerasa, "BROJ_TERASA");
            Map(x => x.BrojSoba, "BROJ_SOBA");
            Map(x => x.Internet, "INTERNET");
            Map(x => x.TV, "TV");
            Map(x => x.Kuhinja, "KUHINJA");
            Map(x => x.Dimenzije, "DIMENZIJE");
            Map(x => x.TipKreveta, "TIP_KREVETA");
            Map(x => x.Spratnost, "SPRATNOST");
            Map(x => x.Dvoriste, "DVORISTE");
            Map(x => x.Sprat, "SPRAT");
            Map(x => x.Lift, "LIFT");
            Map(x => x.Objekat, "OBJEKAT");

            References(x => x.Vlasnik).Column("ID").LazyLoad();
            References(x => x.Kvart).Column("NAZIV").LazyLoad();

            HasMany(x => x.ListaDodatneOpreme).KeyColumn("ID_NEKRETNINE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ListaSajtova).KeyColumn("ID_NEKRETNINA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ListaParkinga).KeyColumn("ID_NEKRETNINE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ListaNajmova).KeyColumn("ID_NEKRETNINE").LazyLoad().Cascade.All().Inverse();

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIP_NEKRETNINE");
        }
    }

    class SobaMapiranja : SubclassMap<Soba>
    {
        public SobaMapiranja()
        {
            DiscriminatorValue("SOBA"); //dodati
        }
    }

    class StanMapiranja : SubclassMap<Stan>
    {
        public StanMapiranja()
        {
            DiscriminatorValue("STAN");
        }
    }

    class KucaMapiranja : SubclassMap<Kuca>
    {
        public KucaMapiranja()
        {
            DiscriminatorValue("KUCA");
        }
    }
}
