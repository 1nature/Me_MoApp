using System.Threading.Channels;

namespace Me_MoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            //var posts = TestData.MakePosts().Take(2).ToList();


            //var aPost = posts.First();

            ////Console.WriteLine(aPost.TotalVotes);

            //var bPost = posts[1];
            //Console.WriteLine(bPost.TotalVotes);


            //foreach (var u in TestData.GetUsers())


            //{
            //    //Console.WriteLine(u.FirstName + LogicMethod.IsUserValidated(u, posts));
            //    Console.WriteLine(u.FirstName);
            //}

            //bool x = LogicMethod.IsUserValidated(TestData.GetUsers()[3], TestData.MakePosts());
            //Console.WriteLine(x); //need to figure out how the individual user votes in the posts

            //int x = LogicMethod.GetAllVotesForUser(TestData.GetUsers()[4], TestData.MakePosts());
            //Console.WriteLine(x);

            //int y = LogicMethod.GetAllVotes(TestData.MakePosts());
            //Console.WriteLine(y);
            //StatusCategory x = LogicMethod.GetPostStatus(TestData.MakePosts()[2], TestData.MakePosts());
            //Console.WriteLine(x);

            //Get the name of users that make posts
            var Posts = TestData.MakePosts();
            

            var x = Posts[2];
            
            foreach (var item in x.TheComments) //LINQ equivalent
            {
                Console.WriteLine(item.Text);
            }
            //linq example that makes sense
            var allCommentsOver5letters = x.TheComments.Where(c => c.Text.Length > 5);

            //foreach (var item in x)
            //{
            //    Console.WriteLine(item.C);
            //}
            ////string x = Posts[2].Comment.Text;
            //Console.WriteLine(x);
            //foreach (var p in Posts)
            //{
            //    Console.WriteLine(p.User.FirstName + " " + p.User.LastName);
            //}

            //Posts.ForEach(p => Console.WriteLine(p.User.FirstName + " " + p.User.LastName));

            //Get the comment from post
            //foreach (var Post in Posts)
            //{
            //    Console.WriteLine(Post.User.FirstName + " " + Post.Comment.Text);
            //}
            //Console.WriteLine();
            //Posts.ForEach(p => Console.WriteLine(p.User.LastName + " " + p.Comment.Text));

            //Get comment from one post
            foreach (var Post in Posts)
            {
                foreach (var Post2 in Post.TheComments)
                {
                    //Console.WriteLine(Post2.Text);
                }
                //Console.WriteLine(Post.Comment.Text);

            }



        }
    }
}
