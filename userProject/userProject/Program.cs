using System;

namespace userProject
{
    class Program
    {
        static void Main(string[] args)
        {
      User user1 = new User().CreateUser(1, "John Doe", "johndoe@example.com", "1234567890");
      UserPhone newphone = new UserPhone{PhoneID=1,PhoneNumber="5555",UserID=user1.UserID};
      user1.AddPhone(newphone);
user1.UserInfo();




            //Console.ReadLine();
        }
    }
}
