namespace Joga.model
{
    public class Hold
    {
        //properties
        public int holdNummer {  get; set; }
        public string holdNavn { get; set; }
        public string holdBeskrivelse { get; set; }
        public List<Medlem> holdMedlemListe { get; set; }
        public string holdUnderside { get; set; }

        //constructor
        public Hold()
        {
            holdNummer = 0;
            holdNavn = string.Empty;
            holdBeskrivelse = string.Empty;
            holdMedlemListe = new List<Medlem>(0);
            holdUnderside = string.Empty;
        }
        public Hold(int holdnummer, string holdnavn, string holdbeskrivelse, string underside)
        {
            holdNummer = holdnummer;
            holdNavn = holdnavn;
            holdBeskrivelse = holdbeskrivelse;
            holdMedlemListe = new List<Medlem>(0);
            holdUnderside = underside;
        }



        //tostring override
        public override string ToString()
        {
            return $"{{{nameof(holdNummer)}={holdNummer.ToString()}, {nameof(holdNavn)}={holdNavn}, {nameof(holdBeskrivelse)}={holdBeskrivelse}, {nameof(holdMedlemListe)}={holdMedlemListe}}}";
        }

    }
}
