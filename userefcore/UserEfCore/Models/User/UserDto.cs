using System;
using UserEfCore.Data;
using UserEfCore.Models.Phone;

namespace UserEfCore.Models.User
{
	public class UserDto
	{
        public int Id { get; set; }
        public string? Name { get; set; }


        public virtual IList<PhoneDto>? Phones { get; set; }
    }
}

