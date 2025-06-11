namespace Me_MoApp
{
    public class Validate
    {
        public int ID { get; set; }
        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
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

        private double _validationScore;
        public double ValidationScore
        {
            get { return _validationScore; }
            set { _validationScore = value; }
        }

        private bool _isValidated;
        public bool IsValidated
        {
            get { return _isValidated; }
            set
            {
                if (ValidationScore > 90)
                {
                    _isValidated = true;
                }
            }
        }

        private bool _thevalidate;
        public bool TheValidate
        {
            get { return ValidationScore > 90; }
        }

        private bool _hasvalidated = new();
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
    }
}
