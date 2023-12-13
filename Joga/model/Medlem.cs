namespace Joga.model
{
    public class Medlem : Person
    {
        //instans felt
        
        private bool _status;
        private bool _nyhedsbrev;

        //properties        

        public bool Status 
        {
            get { return _status; }
            set { _status = value; }
        }
        public bool Nyhedsbrev
        {
            get { return _nyhedsbrev; }
            set { _nyhedsbrev = value; }
        }

        //Konstruktør
        public Medlem() : base()
        {            
            _status = true;
        }

        public Medlem(int id, string navn, string email, string telefon, bool status, bool nyhedsbrev):  base(id, navn, email, telefon)
        {     
            _status = status;
            _nyhedsbrev=nyhedsbrev;
        }

        //tostring override
        public override string ToString()
        {
            return $"{{{nameof(Status)}={Status.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Navn)}={Navn}, {nameof(Email)}={Email}, {nameof(Telefon)}={Telefon}}}";
        }

    }
}
