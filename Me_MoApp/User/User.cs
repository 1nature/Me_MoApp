namespace Me_MoApp
{
    public class User 
    {

        public int ID { get; set; } 

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _picture;

        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }


        private string _sex;
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private Validate _validate;

        public Validate Validate
        {
            get { return _validate; }
            set { _validate = value; }
        }

        private Vendor _vendor = new();
        public Vendor Vendor
        {
            get { return _vendor; }
            set { _vendor = value; }
        }

        private Phone _phone = new();
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
