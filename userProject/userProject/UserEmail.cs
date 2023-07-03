namespace userProject
{
    public class UserEmail
    {
        public int UserEmailId { get; set; }
        public string UserEmailAdress { get; set; }
        public int UserID { get; set; }
        public User? User { get; set; }
    }
}