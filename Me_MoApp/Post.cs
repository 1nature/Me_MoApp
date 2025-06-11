namespace Me_MoApp
{
    public class Post
    {
        public int ID { get; set; }

        private StatusCategory _status = new();
        public StatusCategory Status
        {
            get { return _status; }
            set { _status = value; }

        }


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

        private List<Vote> _votes = new();
        public List<Vote> Votes
        {
            get { return _votes; }
            set { _votes = value; }
        }

        private DateTime _timeStamp = new();
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        public int TotalVotes
        {
            get
            {
                int totalVotes = 0;
                foreach (Vote v in Votes)
                {
                    totalVotes += v.Value;
                }
                return totalVotes;
            }
        }

        public override string ToString()
        {
            return $"{User.FirstName} {User.LastName} - {Description}";
        }


        public void UpVote()
        {
            var vote = new Vote();
            vote.Value = 1;
            vote.User = User;

            //check if user has already voted
            foreach (var v in Votes)
            {
                if (v.User == User)
                {
                    //user has already voted
                    return;
                }
            }
            Votes.Add(vote);
        }

        public void DownVote()
        {
            var vote = new Vote();
            vote.Value = -1;
            vote.User = User;

            //check if user has already voted
            foreach (var v in Votes)
            {
                if (v.User == User)
                {
                    //user has already voted
                    return;
                }
            }
            Votes.Add(vote);
        }

        //Render these
        //Think about user changing their vote
    }
}
