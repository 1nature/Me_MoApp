using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me_MoApp
{
    public class Vendor
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        private Address _address;
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
        //private Address _door;
        //public Address Door
        //{
        //    get { return _door; }
        //    set { _door = value; }
        //}

        //private Address _streetName;
        //public Address StreetName
        //{
        //    get { return _streetName; }
        //    set { _streetName = value; }
        //}

        //private Address _city;
        //public Address City
        //{
        //    get { return _city; }
        //    set { _city = value; }
        //}

        //private Address _country;

        //public Address Country
        //{
        //    get { return _country; }
        //    set { _country = value; }
        //}

        //private Address _email;
        //public Address Email
        //{
        //    get { return _email; }
        //    set { _email = value; }
        //}

        private Phone _phone;
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
