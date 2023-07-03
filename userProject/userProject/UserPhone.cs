namespace userProject
{
    public class UserPhone
    {
        public int UserPhoneId { get; set; }
        public int PhoneNumber { get; set; }
        public int userID { get; set; }
        public User? User { get; set; }
    }
}