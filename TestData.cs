namespace Me_MoApp
{
    public static class TestData
    {
        public static List<User> GetUsers()
        {
            var userList = new List<User>();

            User user1 = new();
            Phone phone1 = new Phone();
            user1.FirstName = "Ayokunle";
            user1.LastName = "Olanipekun";
            user1.Sex = "Male";
            user1.Phone = phone1;
            user1.Phone.PhoneNumber = "07340264066";
            
            User user2 = new();
            Phone phone2 = new Phone();
            user2.FirstName = "John";
            user2.LastName = "Briggs";
            user2.Sex = "Male";
            user2.Phone = phone2;
            user2.Phone.PhoneNumber = "07366264996";


            User user3 = new();
            Phone phone3 = new Phone();
            user3.FirstName = "Sharon";
            user3.LastName = "Stone";
            user3.Sex = "Female";
            user3.Phone = phone3;
            user3.Phone.PhoneNumber = "07356784066";


            User user4 = new();
            Phone phone4 = new Phone();
            user4.FirstName = "Doga";
            user4.LastName = "Golizade";
            user4.Sex = "Female";
            user4.Phone = phone4;
            user4.Phone.PhoneNumber = "07399884066";



            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            userList.Add(user4);

            return userList;
        }

        public static List<Address> GetUserAddress()
        {
            var userAddressList = new List<Address>();

            Address address1 = new();
            address1.Door = "24";
            address1.Street = "Colgrove Drive";
            address1.City = "Southampton";
            address1.Country = "United Kingdom";
            address1.Email = "ola909@gmail.com";

            Address address2 = new();
            address2.Door = "4";
            address2.Street = "King James Close";
            address2.City = "Portsmouth";
            address2.Country = "United Kingdom";
            address2.Email = "yoyo909@gmail.com";

            Address address3 = new();
            address3.Door = "6";
            address3.Street = "King Adediwura About";
            address3.City = "Lagos";
            address3.Country = "Nigeria";
            address3.Email = "rarara@gmail.com";

            userAddressList.Add(address1);
            userAddressList.Add(address2);
            userAddressList.Add(address3);

            return userAddressList;
        }

        public static List<Vendor> GetVendors()
        {
            var theVendorsList = new List<Vendor>();

            Vendor vendor1 = new();
            vendor1.User.BusinessName = "XYZ Ventures";
            vendor1.Address.Door = "9";
            vendor1.Address.City = "Lagos";
            vendor1.Address.Country = "Nigeria";
            vendor1.Address.Email = "xyz99@yahoo.com";
            vendor1.Phone.PhoneNumber = "07775678800";

            Vendor vendor2 = new();
            vendor2.User.BusinessName = "Streams Fashion House";
            vendor2.Address.Door = "9";
            vendor2.Address.City = "Briggs Lane";
            vendor2.Address.Country = "United Kingdom";
            vendor2.Address.Email = "yayo109@yahoo.com";
            vendor2.Phone.PhoneNumber = "07775673459";

            Vendor vendor3 = new();
            vendor3.User.BusinessName = "Josh 2 Fun Designs";
            vendor3.Address.Door = "29";
            vendor3.Address.City = "Border Avenue Crossing";
            vendor3.Address.Country = "United Kingdom";
            vendor3.Address.Email = "lanlap@yahoo.com";
            vendor3.Phone.PhoneNumber = "07555673459";

            theVendorsList.Add(vendor1);
            theVendorsList.Add(vendor2);
            theVendorsList.Add(vendor3);

            return theVendorsList;
        }

        public static List<Comment> MakeComments()
        {
            var commentsList = new List<Comment>();

            Comment comment1 = new();
            comment1.Text = "You def. havn a blast!";
            comment1.TimeStamp = DateTime.Now;

            Comment comment2 = new();
            comment2.Text = "Good one, bruv";
            comment2.TimeStamp = DateTime.Now;

            Comment comment3 = new();
            comment3.Text = "Niceties";
            comment3.TimeStamp = DateTime.Now;

            Comment comment4 = new();
            comment4.Text = "...lol";
            comment4.TimeStamp = DateTime.Now;

            commentsList.Add(comment1);
            commentsList.Add(comment2);
            commentsList.Add(comment3);
            commentsList.Add(comment4);

            return commentsList;
        }
        public static List<Post> MakePosts() 
        {
            var rng = new Random();
            var thePostsList = new List<Post>();

            Post post1 = new();
            post1.User = GetUsers().First();
            post1.Address = GetUserAddress()[0];
            post1.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg"; //what if 2 or more posts?
            PostCategory post1Category = PostCategory.Party;
            post1.Categorization = post1Category;
            post1.Description = "....party vibes";
            for (int i = 0; i < 50; i++)
            {
                post1.Vote(1, GetUsers()[rng.Next(GetUsers().Count)]);
            }

            for (int i = 0; i < 50; i++)
            {
                post1.Vote(-1, GetUsers()[rng.Next(GetUsers().Count)]);
            }
            post1.Comment = MakeComments()[0];
            post1.Comment = MakeComments()[1];
            post1.Vendor = GetVendors()[0];
            post1.Status = LogicMethod.GetStatus(LogicMethod.GetVotesForPost(MakePosts()));


            Post post2 = new();
            post2.User = GetUsers()[1];
            post2.Address = GetUserAddress()[1];
            post2.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg"; //what if 2 or more posts?
            PostCategory post2Category = PostCategory.Wedding;
            post2.Categorization = post2Category;
            post2.Description = "....life z simple";

            for (int i = 0; i < 50; i++)
            {
                post2.Vote(1, GetUsers()[rng.Next(GetUsers().Count)]);
            }

            for (int i = 0; i < 50; i++)
            {
                post2.Vote(-1, GetUsers()[rng.Next(GetUsers().Count)]);
            }
            post2.Comment = MakeComments()[2];
            post2.Comment = MakeComments()[3];
            post2.Vendor = GetVendors()[2];
            post2.Status = LogicMethod.GetStatus(LogicMethod.GetVotesForPost(MakePosts()));


            Post post3 = new();
            post3.User = GetUsers()[2];
            post3.Address = GetUserAddress()[2];
            post3.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg"; //what if 2 or more posts?
            PostCategory post3Category = PostCategory.Office;
            post3.Categorization = post3Category;
            post3.Description = "....one look@atime";
            
            for(int i = 0; i < 150; i++)
            {
                post3.Vote(1, GetUsers()[rng.Next(GetUsers().Count)]);
            }

            for (int i = 0; i < 50; i++)
            {
                post3.Vote(-1, GetUsers()[rng.Next(GetUsers().Count)]);
            }
            post3.Comment = MakeComments()[0];
            post3.Comment = MakeComments()[2];
            post3.Vendor = GetVendors()[3];
            post3.Status = LogicMethod.GetStatus(LogicMethod.GetVotesForPost(MakePosts()));
            

            thePostsList.Add(post1);
            thePostsList.Add(post2);
            thePostsList.Add(post3);

            return thePostsList;
        }

        public static List<Validate> ValidateUsers()
        {
            var theValidationList = new List<Validate>();

            Validate validateUser1 = new();
            validateUser1.Post.User = GetUsers()[0];
            validateUser1.AllUserVotes = LogicMethod.GetAllVotes(MakePosts());
            validateUser1.EachUserVote = LogicMethod.GetAllVotesForUser(validateUser1.Post.User, MakePosts());
            validateUser1.ValidationScore = LogicMethod.CalculateValidationScore(validateUser1.AllUserVotes, validateUser1.AllUserVotes);
            validateUser1.User.ValidateUser(validateUser1.Post.User, validateUser1.ValidationScore);

            Validate validateUser2 = new();
            validateUser2.Post.User = GetUsers()[1];
            validateUser2.AllUserVotes = LogicMethod.GetAllVotes(MakePosts());
            validateUser2.EachUserVote = LogicMethod.GetAllVotesForUser(validateUser2.Post.User, MakePosts());
            validateUser2.ValidationScore = LogicMethod.CalculateValidationScore(validateUser2.AllUserVotes, validateUser2.AllUserVotes);
            validateUser2.User.ValidateUser(validateUser2.Post.User, validateUser2.ValidationScore);

            theValidationList.Add(validateUser1);
            theValidationList.Add(validateUser2);


            return theValidationList;
        }
        
    }
}
