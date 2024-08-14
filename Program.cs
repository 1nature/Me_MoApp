namespace Me_MoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var posts = TestData.MakePosts().Take(2).ToList();


            var aPost = posts.First();

            //Console.WriteLine(aPost.TotalVotes);

            var bPost = posts[1];
            //Console.WriteLine(bPost.TotalVotes);


            //foreach (var u in TestData.GetUsers())


            //{
            //    //Console.WriteLine(u.FirstName + LogicMethod.IsUserValidated(u, posts));
            //    Console.WriteLine(u.FirstName);
            //}

            //bool x = LogicMethod.IsUserValidated(TestData.GetUsers()[1], TestData.MakePosts());
            //Console.WriteLine(x);

            //int x = LogicMethod.GetAllVotesForUser(TestData.GetUsers()[4], TestData.MakePosts());
            //Console.WriteLine(x);

            //int y = LogicMethod.GetAllVotes(TestData.MakePosts());
            //Console.WriteLine(y);
            //StatusCategory x = LogicMethod.GetPostStatus(TestData.MakePosts()[0], TestData.MakePosts());
            //Console.WriteLine(x);

        }
    }
}
