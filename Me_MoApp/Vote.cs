namespace Me_MoApp
{
    public class Vote
    {
        public int Value { get; set; } //either +1 or -1
        public DateTime TimeStamp { get; set; }
        public User User { get; set; } //User who voted
    }







    //public class Vote_old
    //{
    //    private DateTime _timeStamp;
    //    public DateTime TimeStamp
    //    {
    //        get { return _timeStamp; }
    //        set { _timeStamp = value; }
    //    }

    //    private int _totalvote;
    //    public int TotalVote  //TODO: either +1 or -1
    //    {
    //        get { return _totalvote; }
    //        set
    //        {
    //            _totalvote = Vot.UpVote + Vot.DownVote;
    //            //_totalvote = value;
    //        }
    //    }

    //    private int _upvote;

    //    public int UpVote //TODO: either +1 or -1
    //    {
    //        get { return _upvote; }
    //        set { _upvote = value; }
    //    }

    //    private int _downvote;

    //    public int DownVote //TODO: either +1 or -1
    //    {
    //        get { return _downvote; }
    //        set
    //        {
    //            _downvote = -1;
    //            //if (value < 0)
    //            //{
    //            //    _downvote = value;
    //            //}
    //        }
    //    }



    //    private List<Vote> _votes = new List<Vote>(); //this list stores all votes
    //    public List<Vote> Votes //User is not known when their vote is added to the list
    //    {
    //        get { return _votes; }
    //        set { _votes = value; }
    //    }

    //    //How to record all votes?

    //    //public int TotalVotes
    //    //{
    //    //    get
    //    //    {
    //    //        int totalvotes = 0;
    //    //        foreach (Vote vo in _votes)
    //    //        {
    //    //            totalvotes += vo.TotalVote;
    //    //        }

    //    //        return totalvotes;
    //    //    }
    //    //}

    //    //public void CalculateVote(int points, User u)
    //    //{
    //    //    Vote userVote = new();
    //    //    userVote.TimeStamp = DateTime.Now;
    //    //    userVote.User = u;
    //    //    userVote.TotalVote = points;

    //    //    _votes.Add(userVote);
    //    //}

    //    private Vote _vot;

    //    public Vote Vot
    //    {
    //        get { return _vot; }
    //        set { _vot = value; }
    //    }


    //    // No reason to have User in the Vote class
    //    private User _user;
    //    public User User
    //    {
    //        get { return _user; }
    //        set { _user = value; }
    //    }
    //}

    
}
