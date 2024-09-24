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
            user1.Picture = @"/images/Ayo_Peks.jpg";
            user1.Sex = "Male";
            user1.Phone = phone1;
            user1.Phone.PhoneNumber = "07340264066";
            user1.ID = 1;
            
            User user2 = new();
            Phone phone2 = new Phone();
            user2.FirstName = "John";
            user2.LastName = "Briggs";
            user2.Picture = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg";
            user2.Sex = "Male";
            user2.Phone = phone2;
            user2.Phone.PhoneNumber = "07366264996";
            user2.ID = 2;


            User user3 = new();
            Phone phone3 = new Phone();
            user3.FirstName = "Sharon";
            user3.LastName = "Stone";
            user3.Picture = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg";
            user3.Sex = "Female";
            user3.Phone = phone3;
            user3.Phone.PhoneNumber = "07356784066";
            user3.ID = 3;

            User user4 = new();
            Phone phone4 = new Phone(); //no need for this here. Should be elsewhere
            user4.FirstName = "Doga";
            user4.LastName = "Golizade";
            user4.Picture = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg";
            user4.Sex = "Female";
            user4.Phone = phone4;
            user4.Phone.PhoneNumber = "07399884066";
            user4.ID = 4;

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
            vendor1.BusinessName = "XYZ Ventures";
            vendor1.Address.Door = "9";
            vendor1.Address.City = "Lagos";
            vendor1.Address.Country = "Nigeria";
            vendor1.Address.Email = "xyz99@yahoo.com";
            vendor1.Phone.PhoneNumber = "07775678800";

            Vendor vendor2 = new();
            vendor2.BusinessName = "Streams Fashion House";
            vendor2.Address.Door = "9";
            vendor2.Address.City = "Briggs Lane";
            vendor2.Address.Country = "United Kingdom";
            vendor2.Address.Email = "yayo109@yahoo.com";
            vendor2.Phone.PhoneNumber = "07775673459";

            Vendor vendor3 = new();
            vendor3.BusinessName = "Josh 2 Fun Designs";
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
            comment1.User = GetUsers().First();
            comment1.Text = "You def. havn a blast!";
            comment1.TimeStamp = DateTime.Now;

            Comment comment2 = new();
            comment2.Text = "Good one, bruv";
            comment2.User = GetUsers().First();
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
            post1.Path = @"/images/_SLK9321.jpg"; //what if 2 or more posts?
            post1.User.Vendor = GetVendors().First();  
            PostCategory post1Category = PostCategory.Party;
            post1.Categorization = post1Category;
            post1.Description = "....party vibes";

            for (int i = 0; i < 70; i++)
            {
                post1.Vote(1, GetUsers()[rng.Next(GetUsers().Count)]);//randomness to change the users randomly
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    post1.Vote(-1, GetUsers()[rng.Next(GetUsers().Count)]);
            //}

            //post1.User.Comment = MakeComments()[0];
            //post1.User.Comment = MakeComments()[1];

            //This may not work
            post1.TheComments.Add(MakeComments()[0]);
            post1.TheComments.Add(MakeComments()[1]);
            post1.ID = 1;


            Post post2 = new();
            post2.User = GetUsers()[1];
            post2.Address = GetUserAddress()[1];
            post2.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg"; //what if 2 or more posts?
            post2.User.Vendor = GetVendors()[1];
            PostCategory post2Category = PostCategory.Wedding;
            post2.Categorization = post2Category;
            post2.Description = "....life z simple";

            for (int i = 0; i < 5; i++)
            {
                post2.Vote(1, GetUsers()[rng.Next(GetUsers().Count)]);
            }

            //for (int i = 0; i < 4; i++)
            //{
            //    post2.Vote(-1, GetUsers()[rng.Next(GetUsers().Count)]);
            //}
            
            //post2.User.Comment = MakeComments()[2];
            //post2.User.Comment = MakeComments()[3];

            //This may not work
            post2.TheComments.Add(MakeComments()[2]);
            post2.TheComments.Add(MakeComments()[3]);
            post2.ID = 2;



            Post post3 = new();
            post3.User = GetUsers()[2];
            post3.Address = GetUserAddress()[2];
            post3.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg"; //what if 2 or more posts?
            post3.User.Vendor = GetVendors()[2];
            PostCategory post3Category = PostCategory.Office;
            post3.Categorization = post3Category;
            post3.Description = "....one look@atime";
            
            for(int i = 0; i < 10; i++)
            {
                post3.Vote(1, GetUsers()[rng.Next(GetUsers().Count)]);
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    post3.Vote(-1, GetUsers()[rng.Next(GetUsers().Count)]);
            //}

            //post3.User.Comment = MakeComments()[0];
            //post3.User.Comment = MakeComments()[2];
            

            //This may not work
            post3.TheComments.Add(MakeComments()[0]);
            post3.TheComments.Add(MakeComments()[2]);
            post1.ID = 3;

            thePostsList.Add(post1);
            thePostsList.Add(post2);
            thePostsList.Add(post3);
            
            return thePostsList;
        }

        //USE LINQ
       //Get the name of users that make posts
       //Get the comment from post
       //Get comment from one post
       //Get user address & comment from post/posts
       //Get user name, address, vendor info from a post
       //What if a user has mulitiple uploads/paths
        
    }
}
