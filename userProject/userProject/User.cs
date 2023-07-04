using System.Collections.Generic;

namespace userProject
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public List<UserPhone> UserPhones { get; set; }
        public UserEmail UserEmail { get; set; }

        public User()
        {
            UserPhones = new List<UserPhone>();
            UserEmail = new UserEmail();
        }

        public void AddPhone(UserPhone phone)
        {
            UserPhones.Add(phone);
        }

        public void RemovePhone(UserPhone phone)
        {
            UserPhones.Remove(phone);
        }

        public void UpdateEmail(UserEmail email)
        {
            UserEmail = email;
        }

		public void UserInfo()
		{
			Console.WriteLine("---------------------------------");
			Console.WriteLine("User ID: " + this.UserID);
            Console.WriteLine("User Name: " + this.UserName);
            Console.WriteLine("User Email Address: " + this.UserEmail.EmailAddress);

            Console.WriteLine("User Phones:");
            foreach (var phone in this.UserPhones)
            {
                Console.WriteLine("Phone Number: " + phone.PhoneNumber);
            }
			Console.WriteLine("---------------------------------");
		}
    }
}
