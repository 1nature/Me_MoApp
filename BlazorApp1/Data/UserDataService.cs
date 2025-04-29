using Me_MoApp;

namespace BlazorApp1.Data
{
    public class UserDataService
    {

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

        public List<User> Users { get; set; } 

        public UserDataService()
        {
            //Users = GetUsers();
            Users = LogicMethod.LoadUserDataFromDisk(); //TODO: implement DE-serialisation
            //Comments = GetTestComments();
        }

        public void Save()
        {
            LogicMethod.SaveUserDataToDisk(Users); 

        }


    }
}