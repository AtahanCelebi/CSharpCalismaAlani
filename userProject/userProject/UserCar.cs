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
        public UserCar(int carID, string carName)
        {
            CarID = carID;
            CarName = carName;
            Users = new List<User>();
        }

       
        
       public UserCar CreateCar(int carID,string CarName )
       {
        if(string.IsNullOrEmpty(CarName))
        {
            Console.WriteLine("Eksik veya hatalı bilgi girdiniz");
            return null;
        }
        else{
            UserCar newCar = new UserCar(carID,CarName);
            return newCar;
        }

       } 
    }
}