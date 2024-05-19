
namespace StanNaDan.Entiteti;

public class Email
{
    public virtual EmailId Id { get; set; }
    public virtual string EMAIL { get; set; }

    public virtual Vlasnik Vlasnik { get; set; }

    public Email()
    {
        Id = new EmailId();
    }

}