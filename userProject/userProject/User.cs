using System;
using System.Collections.Generic;
namespace userProject
{
	public class User
	{
		public int userID { get; set; }
		public string userName { get; set; }
		public List<UserPhone> UserPhones { get; set; }
		public UserEmail UserEmail { get; set; }
        


		public User()
		{
            UserPhones = new List<UserPhone>();
            UserEmail = new UserEmail();
		}

    }

}

