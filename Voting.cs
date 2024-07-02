namespace Me_MoApp
{
    public class Voting
    {
        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        //private int _voteCounter;
        //public int VoteCounter
        //{
        //    get { return _voteCounter; } //set voting condition
        //    set { _voteCounter = value; }
        //}
        private bool _isVoted;
        public bool IsVoted
        {
            get { return _isVoted; }
            set { _isVoted = value; }
        }

        public int CountVote(bool isVoted)
        {
            int counter = 0;
            if (isVoted)
            {
                counter++;
            }
            else
            {
                counter--;
            }
            return counter;
        }

        private Voting _voteCounter;

        public Voting VoteCounter
        {
            get { return _voteCounter; }
            set 
            {
                if (IsVoted == true)
                {
                    _voteCounter = value;
                }

            }
        }


        //private int _voteCounter;
        //public int VoteCounter
        //{
        //    get { return _voteCounter; } //set voting condition
        //    set 
        //    { 
        //        _voteCounter = value++; 
        //    }
        //}

       

        
        private Voting _theVote;
        public Voting TheVote
        {
            get { return _theVote; }
            set { _theVote = value; }
        }

        public bool IsValidated
        {
            get
            {
                return TheVote.VoteCounter > 50;
            }
        }

        //start here tomorrow
    }
}
