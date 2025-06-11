namespace Me_MoApp
{
    public class Phone
    {
        public int ID { get; set; }
        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        
    }
}
