using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;




namespace StanNaDan.Mapiranja;

//CREATE TABLE IMA_NAJAM(
// ID_NAJMA INT,
// ID_NEKRETNINE INT,
// PRIMARY KEY (ID_NAJMA, ID_NEKRETNINE),
// FOREIGN KEY (ID_NAJMA) REFERENCES NAJAM(ID),
// FOREIGN KEY (ID_NEKRETNINE) REFERENCES NEKRETNINA(ID)
//);

public class ImaNajamMapiranja : ClassMap<StanNaDan.Entiteti.ImaNajam>
{
    public ImaNajamMapiranja()
    {
        Table("IMA_NAJAM");

        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();


        References(x => x.Najam).Column("ID_NAJMA");


        References(x => x.Nekretnina).Column("ID_NEKRETNINE").LazyLoad();


    }
}
