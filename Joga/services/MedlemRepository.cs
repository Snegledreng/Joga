using Joga.model;

namespace Joga.services
{
    public class MedlemRepository
    {
        //Instansfelt og properties(Get/Set)
        public List<Medlem> MedlemList { get; set; }

        //Konstruktør
        public MedlemRepository()
        {
            MedlemList = new List<Medlem>();
        }

    }
}
