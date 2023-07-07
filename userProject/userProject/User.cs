using System.Collections.Generic; 
using userProject; 
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

    public User(int userID, string userName)
    {
        UserID = userID;
        UserName = userName;
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
        Console.WriteLine("User ID: " + UserID);
        Console.WriteLine("User Name: " + UserName);
        Console.WriteLine("User Email Address: " + UserEmail.EmailAddress);

        Console.WriteLine("User Phones:");
        foreach (var phone in UserPhones)
        {
            Console.WriteLine("Phone Number: " + phone.PhoneNumber);
        }
        Console.WriteLine("---------------------------------");
    }
    
    public User CreateUser(int userID, string userName, string emailAddress, string phoneNumber)
{
    User user = new User(userID, userName);

    UserPhone phone = new UserPhone()
    {
        PhoneID = 1,
        PhoneNumber = phoneNumber,
        UserID = user.UserID
    };

    UserEmail email = new UserEmail()
    {
        UserEmailID = 1,
        EmailAddress = emailAddress,
        UserID = user.UserID
    };

    user.AddPhone(phone);
    user.UpdateEmail(email);

    return user;
}

}
