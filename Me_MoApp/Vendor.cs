using System.ComponentModel.DataAnnotations;

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

        //public List<string> BusinessNameList { get; set; } = new List<string>();
        //private List<string> _businessNameList;
        //public List<string> BusinessNameList;
        //{
        //    get { return _businessNameList.Add(_businessName); }
        //}


        //private bool _thevalidate;
        //public bool TheValidate
        //{
        //    get { return Validatte.ValidationScore > 90; }
        //}



        //private List<string> _businessName = new();
        //public List<string> BusinessName
        //{
        //    get { return _businessName; }
        //    set { _businessName = value; }
        //}



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
