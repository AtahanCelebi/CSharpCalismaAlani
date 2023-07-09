using System;

namespace userProject
{
    class Program
    {
        static void Main(string[] args)
        {
      User user1 = new User().CreateUser(1, "Ata", "ata@ata.com", "1234567890");
      
      user1.AddPhone("1231233");
      user1.AddPhone("23123");
user1.UserInfo();
user1.RemovePhone("23123");
user1.UserInfo();


User user2 = new User().CreateUser(1, "abc","1","1");
user2.UserInfo();
user2.UpdateEmail("deneme@deneme.com");
user2.UserInfo();

UserCar bmw = new UserCar().CreateCar(1,"bmw");
bmw.AddCarToUser(user2);
user2.UserInfo();


bmw.AddCarToUser(user1);
user1.UserInfo();

user1.Info();



            //Console.ReadLine();
        }
    }
}
