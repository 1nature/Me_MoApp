using Me_MoApp;

namespace BlazorApp1.Data
{
    public class PostDataService
    {
        public PostDataService() 
        {
            Posts = GetTestPosts();
            Comments = GetTestComments();
        }

        public List<Post> Posts { get; set; }

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
