namespace Me_MoApp
{
    public class Vendor
    {

        private string _businessName;
        public string BusinessName
        {
            get { return _businessName; }
            set { _businessName = value; }
        }

        private Address _address = new();
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private Phone _phone = new();
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
