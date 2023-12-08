namespace Joga.model
{
    public class Medlem : Person
    {
        //instans felt
        
        private bool _status;

        //properties        

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        //Konstruktør
        //Default
        public Medlem() : base()
        {            
            _status = false;
        }

        public Medlem(int id, string navn, string email, string telefon, bool status):  base(id, navn, email, telefon)
        {     
                        _status = status;
        }
    }
}
