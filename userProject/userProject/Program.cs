using System;
using System.Collections.Generic;

namespace userProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.userID = 1;
            user.userName = "Atahan";

            UserPhone phone = new UserPhone();
            phone.userID = user.userID; //ata
            phone.UserPhoneId = 1001;
            phone.PhoneNumber = 5554433;


            UserPhone phone2 = new UserPhone();
            phone2.userID = user.userID;//ata
            phone.UserPhoneId = 1002;
            phone2.PhoneNumber = 2233412;

            user.UserPhones.Add(phone);
            user.UserPhones.Add(phone2);

            //Console.WriteLine($"Kullanıcı {user.userName} ulaşım için {user.UserPhones.ForEach(item=>item.PhoneNumber)}");
            Console.WriteLine($"Kullanıcı {user.userName} ulaşım için {string.Join(", ", user.UserPhones.Select(item => item.PhoneNumber))}");


            user.UserEmail.UserEmailId = 0;
            user.UserEmail.UserEmailAdress = "ata@ata.com";
            user.UserEmail.UserID = user.userID; //userid =1 ata

            Console.WriteLine($"Kullanıcı {user.userName} eposta adresi: {user.UserEmail.UserEmailAdress}");


            Console.ReadLine();
        }
    }
}
