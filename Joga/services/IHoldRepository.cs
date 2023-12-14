using Joga.model;

namespace Joga.services
{
    public interface IHoldRepository
    {
        List<Hold> HoldList { get; set; }

        List<Hold> HentAlleHold();
        Hold HentHold(int holdnummer);
        void SletHold(int holdnummer);
        void TilføjHold(Hold hold);
    }
}