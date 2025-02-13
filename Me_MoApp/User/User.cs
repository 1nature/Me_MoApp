namespace Me_MoApp
{
    public class User
    {

        public int ID { get; set; } 

        //private string _businessName;
        //public string BusinessName
        //{
        //    get { return _businessName; }
        //    set { _businessName = value; }
        //}

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
        //TODO Vendor class be attached to the Post?
        //TODO Vendors in a list?
        //private Comment _comment = new();

        //public Comment Comment
        //{
        //    get { return _comment = new(); }
        //    set { _comment = value; }
        //}


        private Phone _phone = new();
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private List<Validate> _validateusers = new(); //this list stores all validated users
        public List<Validate> ValidatedUsers
        {
            get { return _validateusers; }
            set { _validateusers = value; }
        }

        public void ValidateUser(User u, double score) //Need a method that loops through all to show validation status
        {
            Validate v = new();
            v.TimeStamp = DateTime.Now;
            v.User = u;
            v.Total = score;
            //user.HasValidated = validationStatus;

            _validateusers.Add(v);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
