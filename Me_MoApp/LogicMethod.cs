using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace Me_MoApp
{
    public static class LogicMethod
    {
        public static int GetAllVotes(List<Post> allPosts)
        {
            int total = 0;

            foreach (Post p in allPosts)
            {
                foreach (Vote v in p.Votes)
                {
                    total = total + v.Amount;
                }
            }
            return total;
        }

        public static void SaveDataToDisk(List<Post> savePost) //serialisation
        {
            XmlSerializer writer = new(typeof(List<Post>));

            using (FileStream file = File.Create(Constants.savedPostPath))
            {
                writer.Serialize(file, savePost);
            }
        }

        public static List<Post> LoadDataFromDisk()
        {
            XmlSerializer xmlSerializer = new(typeof(List<Post>));
            List<Post> storedPosts = null;

            if (File.Exists(Constants.savedPostPath))
            {
                using (FileStream file = File.OpenRead(Constants.savedPostPath))
                {
                    storedPosts = xmlSerializer.Deserialize(file) as List<Post>;
                }
            }
            return storedPosts;
        }

        public static int GetAllVotesForUser(User user, List<Post> allPosts)
        {
            int totalUserVote = 0;
            foreach (Post p in allPosts)
            {
                foreach (Vote v in p.Votes)
                {
                    if (v.User.ID == user.ID) //use ID because of value types VS reference type
                    {
                        totalUserVote += v.Amount;
                    }
                }
            }
            return totalUserVote;
        }

        public static double CalculateValidationScore(double totalScore, double userScore)
        {
            double result = totalScore / userScore;
            Math.Round(result);
            return result;
        }

        public static bool IsUserValidated(User u, List<Post> thePosts)
        {
            int totalUserVote = 0;
            int total = 0;

            foreach (Post p in thePosts)
            {
                foreach (Vote v in p.Votes)
                {
                    total += v.Amount;
                }
            }

            foreach (Post p in thePosts)
            {
                foreach (Vote v in p.Votes)
                {
                    if (v.User.ID == u.ID)
                    {
                        totalUserVote += v.Amount; //result of totaluservote is unclear
                    }
                }
            }
            double remainder = total - totalUserVote;

            double result = (totalUserVote / remainder) * 100; //this math is tricky
            Math.Round(result);

            if (result > 90)
            {
                u.Validate.HasValidated = true;
            }
            return u.Validate.HasValidated;
        }
        
        public static StatusCategory GetPostStatus(Post x, List<Post> allPosts)
        {
            int count = 0;
            foreach (Post p in allPosts)
            {
                if (x.ID == p.ID)
                {
                    count = x.TotalVotes;
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
