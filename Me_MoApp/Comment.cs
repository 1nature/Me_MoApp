namespace Me_MoApp
{
    public class Comment
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private User _user = new();

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }


        //Methods to reply, delete & share?
    }
}
