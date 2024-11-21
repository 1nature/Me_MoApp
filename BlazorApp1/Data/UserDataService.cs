using Me_MoApp;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace BlazorApp1.Data
{
    public class UserDataService
    {

        private string _theString = "Hella Verona";

        public String GetString()
        {
            return _theString;
        }



        public List<Me_MoApp.User> GetUsers()
        {
            var users = Me_MoApp.TestData.GetUsers();
            return users;
        }


        public List<Comment> GetTestComments()
        {
            var comments = TestData.MakeComments();
            return comments;
        }

        public UserDataService()
        {
            Users = GetUsers();
            //Comments = GetTestComments();
        }

        public void Save()
        {
            //TODO: serialize user list
        }

        public List<User> Users { get; set; }

        //public User CurrentUser => Me_MoApp.TestData.GetUsers().First();
    }
}