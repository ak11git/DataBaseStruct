using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;




namespace StanNaDan;

public class VlasnikMapiranja : ClassMap<StanNaDan.Entiteti.Vlasnik>
{
    public VlasnikMapiranja()
    {
        Table("VLASNIK");

        Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Ime, "IME");
        Map(x => x.Prezime, "PREZIME");
        Map(x => x.Adresa, "ADRESA");
        Map(x => x.Mesto, "MESTO");
        Map(x => x.Drzava, "DRZAVA");
        Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
        Map(x => x.JMBG, "JMBG");
        Map(x => x.ImeRoditelja, "IME_RODITELJA");
        Map(x => x.Naziv, "NAZIV");
        Map(x => x.PIB, "PIB");

        HasMany(x => x.BankovniRacuni).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.BrojeviTelefona).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Emailovi).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Nekretnine).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();



    }
}













