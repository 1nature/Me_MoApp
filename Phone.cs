using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me_MoApp
{
    public class Phone
    {
        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
