using System.Collections.Generic; 
using userProject; 
using System.Text.Json;
public class User
{
    public int UserID { get; set; }
    public string UserName { get; set; }
    public List<UserPhone> UserPhones { get; set; }
    public UserEmail UserEmail { get; set; }

    public List<UserCar> UserCars { get; set; }

    public User()
    {
        UserPhones = new List<UserPhone>();
        UserEmail = new UserEmail();
        UserCars = new List<UserCar>();
    }

    public User(int userID, string userName)
    {
        UserID = userID;
        UserName = userName;
        UserPhones = new List<UserPhone>();
        UserEmail = new UserEmail();
        UserCars = new List<UserCar>();
    }

    public void AddPhone(string newPhoneNumber )
    {
        if(string.IsNullOrEmpty(newPhoneNumber))
        {
            Console.WriteLine("Telefon numarası boş olamaz");
        }
        else{
        UserPhone newPhone = new UserPhone(){PhoneID=1,PhoneNumber=newPhoneNumber,UserID=this.UserID};
        UserPhones.Add(newPhone);
        }
       
    }

    public void RemovePhone(string removePhoneNumber)
    {
        UserPhone removePhone = UserPhones.FirstOrDefault(item => item.PhoneNumber==removePhoneNumber);
        if(removePhone ==null)
        {
            Console.WriteLine($"{removePhoneNumber} böyle bir numara {this.UserName} kullanıcısına kayıtlı değil");
        }
        else{
            UserPhones.Remove(removePhone);
            Console.WriteLine($"{removePhoneNumber} numarası başarıyla silindi!");
        }
    }

    public void UpdateEmail(string email)
    {
        if(string.IsNullOrEmpty(email))
        {
            Console.WriteLine($"Email boş olamaz!");
        }
        else{
        UserEmail updatedEmail = new UserEmail(){UserEmailID=1,EmailAddress=email,UserID=this.UserID};
        this.UserEmail=updatedEmail;
        Console.WriteLine("Email başarılı şekilde kayıt edildi.");
        }
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
        Console.WriteLine("User Cars:");
        foreach(var car in UserCars)
        {
            Console.WriteLine("Car Name: "+car.CarName);
            
        }

        Console.WriteLine("---------------------------------");
    }
    
    public User CreateUser(int userID, string userName, string emailAddress, string phoneNumber)
{
    if(string.IsNullOrEmpty(userName)||string.IsNullOrEmpty(emailAddress)||string.IsNullOrEmpty(phoneNumber))
    {
        Console.WriteLine("Eksik veya hatalı bilgi girdiniz.");
        return null;
    }
    else
    {
    User user = new User(userID, userName);

    user.AddPhone(phoneNumber);
    user.UpdateEmail(emailAddress);

    return user;
    }
    
}
  public void Info()
    {
        string jsonString = JsonSerializer.Serialize(this);
        Console.WriteLine(jsonString);
    } 
}
