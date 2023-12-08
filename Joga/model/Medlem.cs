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
        public Medlem() : base()
        {            
            _status = false;
        }

        public Medlem(int id, string navn, string email, string telefon, bool status):  base(id, navn, email, telefon)
        {     
                        _status = status;
        }

        //tostring override
        public override string ToString()
        {
            return $"{{{nameof(Status)}={Status.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Navn)}={Navn}, {nameof(Email)}={Email}, {nameof(Telefon)}={Telefon}}}";
        }
    }
}
