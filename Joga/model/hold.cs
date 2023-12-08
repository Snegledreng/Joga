namespace Joga.model
{
    public class Hold
    {
        //properties
        public int holdnummer {  get; set; }
        public string holdnavn { get; set; }
        public string holdbeskrivelse { get; set; }
        public List<Person> tilmeld { get; set; }

        //constructor
        public Hold()
        {
            holdnummer = 0;
            holdnavn = string.Empty;
            holdbeskrivelse = string.Empty;
            tilmeld = new List<Person>();
        }

        //tostring override
        public override string ToString()
        {
            return $"{{{nameof(holdnummer)}={holdnummer.ToString()}, {nameof(holdnavn)}={holdnavn}, {nameof(holdbeskrivelse)}={holdbeskrivelse}, {nameof(tilmeld)}={tilmeld}}}";
        }
    }
}
