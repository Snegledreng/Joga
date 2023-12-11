using Joga.model;

namespace Joga.services
{
    public class MedlemRepository
    {
        //Instansfelt og properties(Get/Set)
        public List<Medlem> MedlemList { get; set; }

        //Konstruktør
        public MedlemRepository(bool mockData = true)
        {
            MedlemList = new List<Medlem>();

            if (mockData)
            {
                PopulateMedlemRepository();
            }
        }
        private void PopulateMedlemRepository()
        {
            MedlemList.Clear();

            MedlemList.Add(new Medlem(90, "ole", "mail@gmail.com", "88899921", true, true));
            MedlemList.Add(new Medlem(2, "Ollie", "mail@hotmail.com", "12376532", false, false));
            MedlemList.Add(new Medlem(3, "Bo", "mail@live.com", "77662244", true, false));
            MedlemList.Add(new Medlem(4, "Erick", "ericssejeemail@gmail.com", "11992288", true, true));
            MedlemList.Add(new Medlem(5, "Nanna", "bosslady@gmail.com", "77228844", false, false));
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
        

    }

}
