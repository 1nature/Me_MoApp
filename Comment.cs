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

        //private User _picturePath;
        //public User PicturePath
        //{
        //    get { return _picturePath; }
        //}

        //private User _userFirstName;
        //public User UserFirstName
        //{
        //    get { return _userFirstName; }
        //}

        //private User _userLastName;
        //public User UserLastName
        //{
        //    get { return _userLastName; }
        //}

        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }
        //Methods to reply, delete & share?
    }
}
