namespace Me_MoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var posts = TestData.MakePosts().Take(2).ToList();
            foreach (var u in TestData.GetUsers())
            {
                //Console.WriteLine(u.FirstName + LogicMethod.IsUserValidated(u, posts));
                Console.WriteLine(u.FirstName);
            }

        }
    }
}
