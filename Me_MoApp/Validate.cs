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

        // to get all posts
        private List<Post> _posts = new();
        public List<Post> Posts
        {
            get { return _posts; }
            set { _posts = value; }
        }

        public void GetAllPosts()
        {

            // This is just an example, you may want to modify it based on your requirements

            var post = new Post();
            foreach (var p in _posts)
            {
                Posts.Add(post);
            }
        }

        public int SumTheTotalVotesInAllPosts
        {
            get
            {
                var sumOfAllVotes = 0;
                foreach (var p in _posts)
                {
                    int x = p.TotalVotesOnEachPost; //assuming TotalVotesOnEachPost is an int property in Post class
                    sumOfAllVotes += x; 
                }
                return sumOfAllVotes;
            }
        }
        //private double _total;
        //public double Total
        //{
        //    get { return _total; }
        //    set { _total = value; }
        //}

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




        //private bool _isValidated;
        //public bool IsValidated
        //{
        //    get { return _isValidated; }
        //    set
        //    {
        //        if (ValidationScore > 90)
        //        {
        //            _isValidated = true;
        //        }
        //    }
        //}



        //private bool _thevalidate;
        //public bool TheValidate
        //{
        //    get { return ValidationScore > 90; }
        //}

        //private bool _hasvalidated = new();
        //public bool HasValidated
        //{
        //    get { return _hasvalidated; }
        //    set { _hasvalidated = value; }
        //}

        //private double _alluservotes;

        //public double AllUserVotes
        //{
        //    get { return _alluservotes; }
        //    set { _alluservotes = value; }
        //}

        //private double _eachuservote;

        //public double EachUserVote
        //{
        //    get { return _eachuservote; }
        //    set { _eachuservote = value; }
        //}
    }
}
