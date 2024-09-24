using Me_MoApp;

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

        //public User CurrentUser => Me_MoApp.TestData.GetUsers().First();
    }
}