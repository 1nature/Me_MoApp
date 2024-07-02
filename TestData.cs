using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Me_MoApp
{
    public static class TestData
    {
        public static List<User> GetUsers()
        {
            var theUsers = new List<User>();

            User user1 = new ();
            user1.FirstName = "Ayokunle";
            user1.LastName = "Olanipekun";
            user1.Sex = "Male";
            user1.Phone.PhoneNumber = "07340264066";

            theUsers.Add(user1);
            return theUsers;
        }

        public static List<User> GetUserAddress()
        {
            var userAddress = new List<User>();
            
            User address1 = new ();
            address1.Address.Door = "24";
            address1.Address.City = "Southampton";
            address1.Address.Country = "United Kingdom";
            address1.Address.Email = "ola909@gmail.com";

            userAddress.Add(address1);
            return userAddress;
        }

        public static List<Vendor> GetVendors()
        {
            var theVendors = new List<Vendor>();

            Vendor vendor1 = new ();
            vendor1.User.BusinessName = "XYZ Ventures";
            vendor1.Address.Door = "9";
            vendor1.Address.City = "Lagos";
            vendor1.Address.Country = "Nigeria";
            vendor1.Address.Email = "xyz99@yahoo.com";
            vendor1.Phone.PhoneNumber = "07775678899";

            theVendors.Add(vendor1);
            return theVendors;
        }

        public static List<Comment> MakeComments()
        {
            var theComments = new List<Comment>();

            Comment firstComment = new Comment(); 
            firstComment.Text = "You def. havn a blast!";
            firstComment.TimeStamp = DateTime.Now;

            Comment secondComment = new Comment();
            secondComment.Text = "Good one, bruv";
            secondComment.TimeStamp = DateTime.Now;

            theComments.Add(firstComment);
            theComments.Add(secondComment);
            return theComments;
        }

        public static List<Post> MakePosts() // Can I add a second post to the list? How to access?
        {
            var thePosts = new List<Post>();

            Post post1 = new ();
            post1.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg";
            PostCategory post1Category = PostCategory.Party;
            post1.Categorization = post1Category;
            post1.Description = "....party vibes";
            post1.Usercomments = MakeComments();//makes sense? can I access it?
            post1.AddUsers = GetUsers(); //makes sense?
            post1.AddVendors = GetVendors();
            post1.AddUserAddress = GetUserAddress();

            thePosts.Add(post1);
            return thePosts;
        }

        

        //        User firstUser = new User();
        //        firstUser.FirstName = "Job";
        //        firstUser.LastName = "Briggs";
        //        firstUser.Sex = "Male";
        //        firstUser.PhoneNumber = "07734567899";

        //        Address firstAddress = new Address();
        //        firstAddress.Door = "9";
        //        firstAddress.Street = "Knottgrass Road";
        //        firstAddress.City = "Southampton";
        //        firstAddress.Country = "United Kingdom";
        //        firstAddress.Email = "ola@yahoo.com";

        //        Vendor firstVendor = new Vendor();
        //        firstVendor.Name = "XYZ Ventures";
        //        Address vendorAddress = new Address();
        //        vendorAddress.Door = "15";
        //        vendorAddress.Street = "Jane Street";
        //        vendorAddress.City = "Birmingham";
        //        vendorAddress.Country = "United Kingdom";
        //        vendorAddress.Email = "xyz@gmail.com";

        //        Comment firstComment = new Comment(); //Maybe a method to generate 2 comments
        //        firstComment.Text = "You def. havn a blast!";
        //        firstComment.TimeStamp = DateTime.Now;

        //        Comment secondComment = new Comment();
        //        secondComment.Text = "Good one, bruv";
        //        secondComment.TimeStamp = DateTime.Now;


        //        Post firstPost = new();
        //        firstPost.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg";
        //        PostCategory firstCategory = PostCategory.Party;
        //        firstPost.Categorization = firstCategory;
        //        firstPost.Description = "...Party vibes";
        //        firstPost.TimeStamp = DateTime.Now;
        //        firstPost.User.Add(firstUser);
        //        firstPost.UserAddress.Add(firstAddress);
        //        firstPost.Vendor.Add(firstVendor);
        //        firstPost.Usercomments.Add(firstComment); 
        //        firstPost.Usercomments.Add(secondComment);


        //    }

        //    public List<Post> Posts()
        //    {


        //        Post firstPost = new();

        //        firstPost.User = Users()[0];
        //        firstPost.Path = @"C:\Users\User\OneDrive\Pictures\_SLK9321.jpg";
        //        PostCategory firstCategory = PostCategory.Party;
        //        firstPost.Categorization = firstCategory;
        //        firstPost.Description = "...Party vibes";
        //        firstPost.TimeStamp = DateTime.Now;         
        //        firstPost.UserAddress.Add(firstAddress);
        //        firstPost.Vendor.Add(firstVendor);
        //        firstPost.Usercomments.Add(firstComment);
        //        firstPost.Usercomments.Add(secondComment);


        //    }

        //    //clean up my objects
        //    //do test data
        //    //remove notification class
        //}
    }
}
