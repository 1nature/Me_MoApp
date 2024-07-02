using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me_MoApp
{
    public class User
    {
        private string _path; //is path necessary here?
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private string _businessName;

        public string BusinessName
        {
            get { return _businessName; }
            set { _businessName = value; }
        }


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

        private string _sex;
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private Phone _phone;
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value; }
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

        //private Address _street;
        //public Address Street
        //{
        //    get { return _street; }
        //    set { _street = value; }
        //}

        //private Address _city;
        //public Address City
        //{
        //    get { return _city; }
        //    set { _city = value; }
        //}



        //private Address _email;
        //public Address Email
        //{
        //    get { return _email; }
        //    set { _email = value; }
        //}

    }
}
