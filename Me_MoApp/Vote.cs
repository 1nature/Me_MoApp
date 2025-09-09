namespace Me_MoApp
{
    public class Vote
    {
        public int ID { get; set; }
        public int Value { get; set; } //either +1 or -1
        public DateTime TimeStamp { get; set; }
        public UserData User { get; set; } //User who voted
        public Post Post { get; set; } //Post that was voted on

    }
    
}
