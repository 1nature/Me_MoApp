using Me_MoApp;

namespace BlazorApp2.Data
{
    public class PostDataService
    {
        public PostDataService()
        {
            //   Posts = GetTestPosts(); //post has data
            //  LogicMethod.SaveDataToDisk(Posts); //post is empty, what am I missing?

            Posts = LogicMethod.LoadPostDataFromDisk(); //TODO: implement DE-serialisation
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


        public List<Comment> Comments { get; set; } = new();

        public List<Comment> GetTestComments()
        {
            var comments = TestData.MakeComments();
            return comments;
        }



        public int TotalAmountOfVotes()
        {
            int total = 0;
            foreach (Post p in Posts)
            {
                foreach (Vote v in p.Votes)
                {
                    {
                        total += v.Value; 
                        //total += p.TotalVotesOnEachPost;
                        //need to bring in user?
                    }
                }
            }
            return total;

        }

    }
}
