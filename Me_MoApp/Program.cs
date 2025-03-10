namespace Me_MoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Posts = TestData.MakePosts();
            

            var x = Posts[2];
            
            foreach (var item in x.TheComments) //LINQ equivalent
            {
                Console.WriteLine(item.Text);
            }

            //linq example that makes sense
            var allCommentsOver5letters = x.TheComments.Where(c => c.Text.Length > 5);

            
            foreach (var Post in Posts)
            {
                foreach (var Post2 in Post.TheComments)
                {
                    //Console.WriteLine(Post2.Text);
                }
            }



        }
    }
}
