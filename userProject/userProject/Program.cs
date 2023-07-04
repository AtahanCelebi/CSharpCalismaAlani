using System;

namespace userProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = CreateUser("Ata","ata@ata.com");
            AddUserPhone(user,"90550505");
            AddUserPhone(user,"30552123");
            user.UserInfo();


            UpdateUserEmail(user,"atahanc@atahanc.com");
            RemoveUserPhone(user,"30552123");
            user.UserInfo();

            UpdateUserPhone(user,"30552123","55232123");
            user.UserInfo();

            UpdateUserPhone(user,"90550505","55232123");
            user.UserInfo();

            //Console.ReadLine();
        }

        static User CreateUser(string userName,string emailAdress)
        {
            Random random = new Random();
            User user = new User()
            {
                UserID = random.Next(1,100),
                UserName = userName,
                UserEmail = new UserEmail(){ EmailAddress =emailAdress}
            };

            return user;
        }

        static void UpdateUserEmail(User user,string emailAdress)
        {
            Random random = new Random();
            UserEmail email = new UserEmail()
            {
                UserEmailID = random.Next(1,100),
                EmailAddress = emailAdress,
                UserID = user.UserID
            };

            user.UpdateEmail(email);
        }

        static void AddUserPhone(User user,string phoneNum)
        {
            UserPhone phone = new UserPhone()
            {
                PhoneID = 1,
                PhoneNumber = phoneNum,
                UserID = user.UserID
            };

            user.AddPhone(phone);
        }

        static void RemoveUserPhone(User user,string phoneNum)
        {
            
        UserPhone phoneToRemove = user.UserPhones.FirstOrDefault(p => p.PhoneNumber == phoneNum);

        if (phoneToRemove != null)
        {
            
            user.UserPhones.Remove(phoneToRemove);
        }
        else
        {
            Console.WriteLine($"Telefon ({phoneNum}) bulunamadı.");
        }
        }

        static void UpdateUserPhone(User user,string oldPhone, string newPhone)
        {
            UserPhone phoneToUpdate = user.UserPhones.FirstOrDefault(p => p.PhoneNumber == oldPhone);

            if(phoneToUpdate != null)
            {
                phoneToUpdate.PhoneNumber = newPhone;
            }
            else
            {
                Console.WriteLine($"Telefon ({oldPhone}) bulunamadı.");
            }
        }
    }
}
