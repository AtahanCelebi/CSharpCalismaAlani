namespace userProject
{
    public class UserCar
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public List<User> Users { get; set; }

        public UserCar()
        {
            Users = new List<User>();
        }
        
    }
}