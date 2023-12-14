using Joga.model;

namespace Joga.services
{
    public class HoldRepository : IHoldRepository
    {
        //Instansfelt og properties(Get/Set)
        public List<Hold> HoldList { get; set; }

        //Konstruktør
        public HoldRepository()
        {
            HoldList = new List<Hold>();
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