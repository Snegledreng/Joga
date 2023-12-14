using Joga.model;

namespace Joga.services
{
    public class MedlemRepository : IMedlemRepository
    {
        //Instansfelt og properties(Get/Set)
        public List<Medlem> MedlemList { get; set; }

        //Konstruktør
        public MedlemRepository()
        {
            MedlemList = new List<Medlem>();
        }



        //metoder

        public List<Medlem> HentAlleMedlemmer()
        {
            return new List<Medlem>(MedlemList);
        }

        public void TilføjMedlem(Medlem medlem)
        {
            MedlemList.Add(medlem);
        }

        public Medlem HentMedlem(int medlemnummer)
        {
            foreach (Medlem medlem in MedlemList)
            {
                if (medlem.Id == medlemnummer)
                {
                    return medlem;
                }
            }
            throw new Exception();
        }
    }

}
