namespace Me_MoApp
{
    public class Validate
    {
        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        private double _total;
        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private StatusCategory _status;
        public StatusCategory Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private Post _post;
        public Post Post
        {
            get { return _post; }
            set { _post = value; }
        }


        private double _validationScore;
        public double ValidationScore
        {
            get { return _validationScore; }
            set { _validationScore = value; }
        }

        private Validate _validate;
        public Validate Validatte
        {
            get { return _validate; }
            set { _validate = value; }
        }

        private bool _isValidated;
        public bool IsValidated
        {
            get { return _isValidated; }
            set
            {
                if (Validatte.ValidationScore > 90)
                {
                    _isValidated = true;
                }
            }
        }

        private bool _thevalidate;
        public bool TheValidate
        {
            get { return Validatte.ValidationScore > 90; }
        }

        private bool _hasvalidated;
        public bool HasValidated
        {
            get { return _hasvalidated; }
            set { _hasvalidated = value; }
        }

        private double _alluservotes;

        public double AllUserVotes
        {
            get { return _alluservotes; }
            set { _alluservotes = value; }
        }

        private double _eachuservote;

        public double EachUserVote
        {
            get { return _eachuservote; }
            set { _eachuservote = value; }
        }


        //public bool IsValidated
        //{
        //    get { return IsValidated; }
        //}


        //private bool _isValidated;
        //public bool IsValidated
        //{
        //    get { return _isValidated; }
        //    set { _isValidated = value; }
        //}

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
