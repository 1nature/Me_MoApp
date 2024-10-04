using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //private User _user;
        //public User User
        //{
        //    get { return _user; }
        //    set { _user = value; }
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
