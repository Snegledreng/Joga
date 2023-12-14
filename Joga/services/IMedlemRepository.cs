using Joga.model;

namespace Joga.services
{
    public interface IMedlemRepository 
    {
        List<Medlem> MedlemList { get; set; }

        List<Medlem> HentAlleMedlemmer();
        Medlem HentMedlem(int medlemnummer);
        void TilføjMedlem(Medlem medlem);
    }
}