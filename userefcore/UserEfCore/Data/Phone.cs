using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace UserEfCore.Data
{
	public class Phone
	{
        public int Id { get; set; }
        public string? PhoneNumber { get; set; }

        [ForeignKey(nameof(UserId))]
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}

