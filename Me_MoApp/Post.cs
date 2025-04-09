namespace Me_MoApp
{
    public class Post
    {
        private StatusCategory _status = new();
        public StatusCategory Status
        {
            get { return _status; }
            set { _status = value; }

        }

        public int ID { get; set; }
        
        private List<string> _paths = new();
        public List<string> Paths
        {
            get { return _paths; }
            set { _paths = value; }
        }

        private PostCategory _categorization = new();
        public PostCategory Categorization
        {
            get { return _categorization; }
            set { _categorization = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private List<Comment> _thecoments = new();

        public List<Comment> TheComments
        {
            get { return _thecoments; }
            set { _thecoments = value; }
        }

        private List<Vendor> _vendor = new();
        public List<Vendor> Vendor
        {
            get { return _vendor; }
            set { _vendor = value; }
        }

        private Address _address = new();
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private User _user = new();
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        private Vote _vote = new();
        public Vote Vote
        {
            get { return _vote; }
            set { _vote = value; }
        }

        private DateTime _timeStamp = new();
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }


        // Not sure if the codes below are supposed to be here
        // I think they should be in the Vote class

        //private List<Vote> _votes = new List<Vote>(); //this list stores all votes
        //public List<Vote> Votes //User is not known when their vote is added to the list
        //{
        //    get { return _votes; }
        //    set { _votes = value; }
        //}

        //public int TotalVotes
        //{
        //    get
        //    {
        //        int totalvotes = 0;
        //        foreach (Vote vo in _votes)
        //        {
        //            totalvotes += vo.TotalVote;
        //        }

        //        return totalvotes;
        //    }
        //}

        //public void Vote(int points, User u)
        //{
        //    Vote userVote = new();
        //    userVote.TimeStamp = DateTime.Now;
        //    userVote.User = u;
        //    userVote.TotalVote = points;

        //    _votes.Add(userVote);
        //}
        //need a way to save a post

        public override string ToString()
        {
            return $"{User.FirstName} {User.LastName} - {Description}";
        }

    }
}
