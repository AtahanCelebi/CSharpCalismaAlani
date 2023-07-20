using System;
namespace UserEfCore.Data
{
	public class User
	{
		public int Id { get; set; }
        public string? Name { get; set; }


        public virtual IList<Phone>? Phones { get; set; }
	}
}

