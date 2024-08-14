using System.Diagnostics.Metrics;

namespace Me_MoApp
{
    public static class LogicMethod
    {
        public static bool GetValidation(int userVote, int totalVote)
        {
            bool toValidate;
            double validationScore = totalVote * 0.9;
            if (userVote >= validationScore)
            {
                toValidate = true;
            }
            else { toValidate = false; }
            return toValidate;
        }

        

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

        //public static bool IsUserValidated(List<Validate>validationList)
        //{
        //    foreach(Validate v in validationList)
        //    {
        //        v.
        //    }
        //}

        public static bool IsUserValidated(User u, List<Post>thePosts)
        {
            int totalUserVote = 0;
            bool validationStatus;

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
                foreach(Vote v in p.Votes)
                {
                    if (v.User == u)
                    {
                        totalUserVote += v.Amount;
                    }
                }
            }

            double result = total / totalUserVote;
            Math.Round(result);

            if( result > 90)
            {
                u.Validate.HasValidated = true;
            }
            return u.Validate.HasValidated;
        }

        public static int GetVotesForPost(List<Post> allPosts)
        {
            int count = 0;
            foreach (Post p in allPosts)
            {
                count += p.Votes.Count;
            }
            return count;
        }

        public static StatusCategory GetStatus(int counter)
        {
            if (counter < 40)
                return StatusCategory.Unranked_UR;
            if (counter < 50)
                return StatusCategory.Naive_N;
            if (counter < 70)
                return StatusCategory.C_list;
            if (counter < 90)
                return StatusCategory.B_list;
            if (counter >= 90)
                return StatusCategory.A_list;

            return StatusCategory.Unranked_UR;
        }

        public static StatusCategory GetPostStatus(Post x, List<Post> allPosts)
        {
            int count = 0;

            foreach (Post p in allPosts)
            {
                foreach (Vote vote in p.Votes)
                {

                }
            }

            //if (allPosts.Contains(x))
            //{
            //    count += x.Votes.Count;
            //}

            //foreach (Post p in allPosts)
            //{
            //    allPosts.Find(p => p == x);

            //    if (allPosts[0] == x)

            //    foreach (Vote v in p.Votes)
            //    {
            //        if (p.Find() == v)
                    
            //        count += p.Votes.Count;
            //    }
                
            //}

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
