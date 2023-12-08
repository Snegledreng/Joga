namespace Joga.model
{
    public class kunde
    {
        //properties
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        //constructors
        public kunde()
        { 
            Id = 0;
            Navn = string.Empty;
            Email = string.Empty;
            Telefon = string.Empty;
        }

        public kunde(int id, string navn, string email, string telefon)
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
