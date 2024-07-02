using Me_MoApp.User;

namespace Me_MoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            var aPost = new Post();

            aPost.User.Address.City

            var aComment = new Comment();
            var aSecondComment = new Comment();

            aComment.TimeStamp = DateTime.Now;

            aPost.TimeStamp = DateTime.Now;

            var aUser = new User.User();

            if(aUser.IsValidated)
            {
                //display blue cehckmark
            }

            //clean classes
            //create methods
            //multilevel like the above
        }
    }
}
