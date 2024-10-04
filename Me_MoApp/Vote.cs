namespace Me_MoApp
{
    public class Vote
    {
        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private int _amount;
        public int Amount  //TODO: either +1 or -1
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
