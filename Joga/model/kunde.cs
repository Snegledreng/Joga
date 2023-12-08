namespace Joga.model
{
    public class Kunde
    {
        //properties
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        //constructors
        public Kunde()
        { 
            Id = 0;
            Navn = string.Empty;
            Email = string.Empty;
            Telefon = string.Empty;
        }

        public Kunde(int id, string navn, string email, string telefon)
        {
            Id = id;
            Navn = navn;
            Email = email;
            Telefon = telefon;
        }



        //tostring override
        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Navn)}={Navn}, {nameof(Email)}={Email}, {nameof(Telefon)}={Telefon}}}";
        }

    }
}
