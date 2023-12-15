using Joga.model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Joga.services
{
    public class MedlemRepositoryJson : IMedlemRepository
    {

        //Instansfelt og properties(Get/Set)
        public List<Medlem> MedlemList { get; set; }

        //Konstruktør
        public MedlemRepositoryJson()
        {
            MedlemList = ReadFromJson();
                      
        }
               
        //metoder

        public List<Medlem> HentAlleMedlemmer()
        {
            return new List<Medlem>(MedlemList);
        }

        public void TilføjMedlem(Medlem medlem)
        {
            MedlemList.Add(medlem);
            WriteToJson();
            
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
            throw new Exception($"Medlemsnummer {medlemnummer} findes ikke");
        }

        //Læs og skriv via Json
        //Const = konstant der ikke kan ændres string
        private const string FILENAME = "MedlemRepository.json";
        private List<Medlem>? ReadFromJson()
        {
            if (File.Exists(FILENAME))
            {
                StreamReader sr = File.OpenText(FILENAME);
                List<Medlem> list = JsonSerializer.Deserialize<List<Medlem>>(sr.ReadToEnd());
                sr.Close();
                return list;
            }
            else
            {
                return new List<Medlem>();
            }
        }

        private void WriteToJson()
        {
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            Utf8JsonWriter writer = new Utf8JsonWriter(fs);
            JsonSerializer.Serialize(writer, MedlemList);
            fs.Close();
        }




    }
}
