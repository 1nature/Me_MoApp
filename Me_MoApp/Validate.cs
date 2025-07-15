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


        public int SumTheTotalVotesInAllPosts
        {
            get;

            set;
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



        public int TotalVotesGeneratedFromUserPosts
        {
            get; set;
        }


        private bool _isValidated;
        public bool IsValidated
        {
            get { return _isValidated; }
            set
            {
                ValidationScore = TotalVotesGeneratedFromUserPosts / SumTheTotalVotesInAllPosts * 100; // Calculate the validation score as a percentage
                if (ValidationScore >= 1) //90
                {
                    _isValidated = true;
                }


                //todo set status accodringly 
            }
        }
    }
}
