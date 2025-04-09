namespace Me_MoApp
{
    public class Vote
    {
        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private int _totalvote;
        public int TotalVote  //TODO: either +1 or -1
        {
            get { return _totalvote; }
            set { _totalvote = value; }
        }

        private List<Vote> _votes = new List<Vote>(); //this list stores all votes
        public List<Vote> Votes //User is not known when their vote is added to the list
        {
            get { return _votes; }
            set { _votes = value; }
        }

        public int TotalVotes
        {
            get
            {
                int totalvotes = 0;
                foreach (Vote vo in _votes)
                {
                    totalvotes += vo.TotalVote;
                }

                return totalvotes;
            }
        }

        public void CalculateVote(int points, User u)
        {
            Vote userVote = new();
            userVote.TimeStamp = DateTime.Now;
            userVote.User = u;
            userVote.TotalVote = points;

            _votes.Add(userVote);
        }


        // No reason to have User in the Vote class
        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
