namespace Joga.model
{
    public class Hold
    {
        //properties
        public int holdnummer {  get; set; }
        public string holdnavn { get; set; }
        public string holdbeskrivelse { get; set; }

        //constructor
        public Hold()
        {
            holdnummer = 0;
            holdnavn = string.Empty;
            holdbeskrivelse = string.Empty;
        }
        public Hold(int holdnummer, string holdnavn, string holdbeskrivelse)
        {
            this.holdnummer = holdnummer;
            this.holdnavn = holdnavn;
            this.holdbeskrivelse = holdbeskrivelse;
        }

       


        //tostring override
        public override string ToString()
        {
            return $"{{{nameof(holdnummer)}={holdnummer.ToString()}, {nameof(holdnavn)}={holdnavn}, {nameof(holdbeskrivelse)}={holdbeskrivelse}";
        }
    }
}
