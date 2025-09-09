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

        private UserData _user = new();
        public UserData User
        {
            get { return _user; }
            set { _user = value; }
        }

        private DateTime _timeStamp = new();
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        //this part downwards should be in the vote class.
        //adjust the program to reflect that especially in the blazor components
        private List<Vote> _votes = new();
        public List<Vote> Votes
        {
            get { return _votes; }
            set { _votes = value; }
        }

        
        public void UpVoteOnPost()
        {
            var existingVote = Votes.FirstOrDefault(v => v.User == User);
            if (existingVote != null)
            {
                existingVote.Value = 1;
            }
            else
            {
                Votes.Add(new Vote { Value = 1, User = User });
            }
        }

        public void DownVoteOnPost()
        {
            //var existingVote = Votes.FirstOrDefault(v => v.User == User);
            Vote existingVote = null;

            foreach (var v in Votes)
            {
                if (v.User == User)
                {
                    existingVote = v;
                    break;
                }
            }


            if (existingVote != null)
            {
                existingVote.Value = -1;
            }
            else
            {
                //Votes.Add(new Vote { Value = -1, User = User });
                Vote newVote = new Vote();
                newVote.Value = - 1;
                newVote.User = User;
                Votes.Add(newVote);

            }
        }

        public int TotalVotesOnEachPost
        {
            get
            {
                return Votes.Sum(v => v.Value);
            }
        }

        //public void UpVoteOnPost()
        //{
        //    var vote = new Vote();
        //    vote.Value = 1;
        //    vote.User = User;

        //    //check if user has already voted
        //    foreach (var v in Votes)
        //    {
        //        if (v.User == User)
        //        {
        //            //user has already voted
        //            return;
        //        }
        //    }
        //    Votes.Add(vote);
        //}

        //public void DownVoteOnPost()
        //{
        //    var vote = new Vote();
        //   vote.Value = -1;
        //    vote.User = User;

        //    //check if user has already voted
        //    foreach (var v in Votes)
        //    {
        //        if (v.User == User)
        //        {
        //            Votes.Add(vote);

        //            //break;
        //            //user has already voted
        //            return;
        //        }
        //    }
        //    //Votes.Add(vote);
        //    //Because user has already voted, it becomes a problem?
        //}

        //public int TotalVotesOnEachPost
        //{
        //    get
        //    {
        //        int totalVotes = 0;
        //        foreach (Vote v in Votes)
        //        {
        //            totalVotes += v.Value;
        //        }

        //        //if (totalVotes != null)
        //        //{
        //        //    return 0; // No votes yet
        //        //}


        //        //if (totalVotes < 0)
        //        //{
        //        //    return 0; // No votes yet
        //        //}

        //        return totalVotes;
        //    }
        //}




        public override string ToString()
        {
            return $"{User.FirstName} {User.LastName} - {Description}";
        }


        //Render these
        //Think about user changing their vote
    } 
}
