using System;
using System.ComponentModel.DataAnnotations;
namespace UserEfCore.Models.User
{
	public abstract class BaseUserDto
	{
		[Required]
		public string? Name { get; set; }
	}
}

