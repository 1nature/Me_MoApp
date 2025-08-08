using System.Xml.Serialization;

namespace Me_MoApp
{
    public static class LogicMethod
    {
        public static int GetAllVotes(List<Post> allPosts)
        {
            int total = 0;
            // These codes were commented because of errors
            // They have errors because I moved some codes from Post class to Vote class
            foreach (Post p in allPosts)
            {
                //foreach (Vote v in p.Votes)
                //{
                //    total = total + v.TotalVote;
                //}
            }
            return total;
        }

        public static void SaveUserDataToDisk(List<User> saveUser) //serialisation
        {
            XmlSerializer writer = new(typeof(List<User>));
            using FileStream file = File.Create(Constants.savedUserPath);
            writer.Serialize(file, saveUser);
        }

        public static List<User> LoadUserDataFromDisk()
        {
            XmlSerializer xmlSerializer = new(typeof(List<User>));
            List<User> storedUsers = new();
            if (File.Exists(Constants.savedUserPath))
            {
                using FileStream file = File.OpenRead(Constants.savedUserPath);
                storedUsers = xmlSerializer.Deserialize(file) as List<User>;
            }
            return storedUsers;
        }

        public static void SavePostDataToDisk(List<Post> savePost) //serialisation
        {
            XmlSerializer writer = new(typeof(List<Post>));

            using (FileStream file = File.Create(Constants.savedPostPath))
            {
                writer.Serialize(file, savePost);
            }
        }



        public static List<Post> LoadPostDataFromDisk()
        {
            XmlSerializer xmlSerializer = new(typeof(List<Post>));
            List<Post> storedPosts = null;

            if (File.Exists(Constants.savedPostPath))
            {
                using FileStream file = File.OpenRead(Constants.savedPostPath);
                storedPosts = xmlSerializer.Deserialize(file) as List<Post>;
            }
            return storedPosts;
        }

        
        public static StatusCategory GetPostStatus(Post x, List<Post> allPosts)
        {
            int count = 0;
            foreach (Post p in allPosts)
            {
                if (x.ID == p.ID)
                {
                    //count = x.TotalVotes;
                }
            }
            
            if (count < 40)
                return StatusCategory.Unranked_UR;
            if (count < 50)
                return StatusCategory.Naive_N;
            if (count < 70)
                return StatusCategory.C_list;
            if (count < 90)
                return StatusCategory.B_list;
            if (count >= 90)
                return StatusCategory.A_list;

            return StatusCategory.Unranked_UR;
        }
    }
}
