using Me_MoApp;

namespace BlazorApp2.Data
{
    public class UserDataService
    {

        public List<Me_MoApp.UserData> GetUsers()
        {
            var users = Me_MoApp.TestData.GetUsers();
            return users;
        }


        public List<Comment> GetTestComments()
        {
            var comments = TestData.MakeComments();
            return comments;
        }

        public List<UserData> Users { get; set; } = new();

        //public UserDataService()
        //{
        //    //Users = GetUsers();
        //    Users = LogicMethod.LoadUserDataFromDisk(); //TODO: implement DE-serialisation
        //    //Comments = GetTestComments();
        //}

        //public void Save()
        //{
        //    LogicMethod.SaveUserDataToDisk(Users); 

        //}


    }
}