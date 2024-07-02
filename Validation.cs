using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me_MoApp
{
    public class Validation
    {
        private bool _isValidated;
        public bool IsValidated
        {
            get { return _isValidated; }
            set { _isValidated = value; }
        }

        ////member variables
        //public string UserName; //bring UserName class instead?
        ////image/picture post
        ////timestamp
        //public int OnlinePostRanker; //bring Voting class instead?

 
        //Thinking this class should be a method somewhere else
    }
    //name private variables with underscore
    //get - is a read only, cannot write to it. 
}
