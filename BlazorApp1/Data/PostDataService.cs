namespace BlazorApp1.Data
{
    public class PostDataService
    {
        public List<Me_MoApp.Post> GetTestPosts()
        {
            var posts = Me_MoApp.TestData.MakePosts();
            return posts;
        }

        public List<Me_MoApp.Comment> GetTestComments()
        {
            var comments = Me_MoApp.TestData.MakeComments();
            return comments;
        }


    }
}
