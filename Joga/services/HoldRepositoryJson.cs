using Joga.model;
using System.Text.Json;

namespace Joga.services
{
    public class HoldRepositoryJson : IHoldRepository
    {

        //Instansfelt og properties(Get/Set)
        public List<Hold> HoldList { get; set; }

        //Konstruktør
        public HoldRepositoryJson()
        {
            HoldList = ReadFromJson();            
        }
        

        //metoder

        public List<Hold> HentAlleHold() => new List<Hold>(HoldList);

        public void TilføjHold(Hold hold)
        {

            HoldList.Add(hold);
            WriteToJson();
        }

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

        public void SletHold(int holdnummer)
        {
            HoldList.Remove(HentHold(holdnummer));
            WriteToJson();
        }



        //Læs og skriv via Json
        //Const = konstant der ikke kan ændres string
        private const string FILENAME = "HoldRepository.json";
        private List<Hold> ReadFromJson()
        {
            if (File.Exists(FILENAME))
            {
                StreamReader sr = File.OpenText(FILENAME);
                List<Hold> list = JsonSerializer.Deserialize<List<Hold>>(sr.ReadToEnd());
                sr.Close();
                return list;
            }
            else
            {
                return new List<Hold>();
            }
        }


        private void WriteToJson()
        {
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            Utf8JsonWriter writer = new Utf8JsonWriter(fs);
            JsonSerializer.Serialize(writer, HoldList);
            fs.Close();
        }



    }
}
