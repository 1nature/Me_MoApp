namespace Me_MoApp
{
    public class Post
    {
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private PostCategory _categorization;

        public PostCategory Categorization
        {
            get { return _categorization; }
            set { _categorization = value; }
        }
        
        //Create enum for validation category

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //public string Comment { get; set; }


        private List<Comment> _userComments; 

        public List<Comment> Usercomments
        {
            get { return _userComments; }
            set { _userComments = value; }
        }

        private List<User> _addUsers;

        public List<User> AddUsers
        {
            get { return _addUsers; }
            set { _addUsers = value; }
        }

        private List<Vendor> _addVendors;

        public List<Vendor> AddVendors
        {
            get { return _addVendors; }
            set { _addVendors = value; }
        }

        private List<User> _addUserAddress;

        public List<User> AddUserAddress
        {
            get { return _addUserAddress; }
            set { _addUserAddress = value; }
        }


        private User _user;
        public User User
        { 
            get { return _user; }
            set { _user = value; }
        }

        private Vendor _vendor;
        public Vendor Vendor
        {
            get { return _vendor; }
            set { _vendor = value; }
        }

        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private ValidationCategory _category;
        public ValidationCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        //private Voting _voteOnPost;
        //public Voting Voteonpost
        //{
        //    get { return _voteOnPost; }
        //    set { _voteOnPost = value; }
        //}
        //Should there be a Voting method that calls the voting class?
    }
}
