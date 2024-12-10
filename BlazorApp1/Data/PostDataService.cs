using Me_MoApp;

namespace BlazorApp1.Data
{
    public class PostDataService
    {
        public PostDataService() 
        {
            //   Posts = GetTestPosts(); //post has data
            //  LogicMethod.SaveDataToDisk(Posts); //post is empty, what am I missing?

            Posts = LogicMethod.LoadDataFromDisk(); //TODO: implement DE-serialisation
            //put a condition to check if file exist like the quiz maker
            //like a method exist

            Comments = GetTestComments();
        }

        public List<Post> Posts { get; set; } = new();

        public List<Post> GetTestPosts()
        {
            var posts = TestData.MakePosts();
            return posts;
        }


        public List<Comment> Comments { get; set; }

        public List<Comment> GetTestComments()
        {
            var comments = TestData.MakeComments();
            return comments;
        }
    }
}
