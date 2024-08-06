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

        public static int GetVotesForPost(List<Post> allPosts)
        {
            int count = 0;
            foreach (Post p in allPosts)
            {
                count = count + p.Votes.Count;
            }
            return count;
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
                    if (v.User == user)
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
    }
}
