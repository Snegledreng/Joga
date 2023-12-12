using Joga.model;

namespace Joga.services
{
    public class HoldRepository
    {
        //Instansfelt og properties(Get/Set)
        public List<Hold> HoldList { get; set; }

        //Konstruktør
        public HoldRepository(bool mockData = false)
        {
            HoldList = new List<Hold>();

            if (mockData)
            {
                PopulateHoldRepository();
            }
        }
        private void PopulateHoldRepository()
        {
            HoldList.Clear();

            HoldList.Add(new Hold(1, "Hot yoga", "Beskrivelse af hot yoga", "HotYoga"));
            HoldList.Add(new Hold(2, "Power yoga", "Beskrivelse af power yoga", "PowerYoga"));
            HoldList.Add(new Hold(3, "Kedelig yoga", "Beskrivelse af kedelig yoga", "KedeligYoga"));
            HoldList.Add(new Hold(4, "Spændende yoga", "Beskrivelse af spændende yoga", "SpændendeYoga"));
            HoldList.Add(new Hold(5, "Almindelig yoga", "Beskrivelse af almindelig yoga", "AlmindeligYoga"));
        }

        //metoder

        public List<Hold> HentAlleHold() => new List<Hold>(HoldList);

        public void TilføjHold(Hold hold) => HoldList.Add(hold);

        public Hold HentHold(int holdnummer)
        {
            foreach (Hold hold in HoldList)
            {
                if (hold.holdNummer == holdnummer)
                {
                    return hold;
                }
            }
            throw new Exception();
        }

        public void SletHold(int holdnummer) => HoldList.Remove(HentHold(holdnummer));


    }
}