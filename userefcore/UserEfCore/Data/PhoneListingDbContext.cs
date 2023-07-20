using System;
using Microsoft.EntityFrameworkCore;
namespace UserEfCore.Data
{
	public class PhoneListingDbContext: DbContext
	{
		public PhoneListingDbContext(DbContextOptions options): base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Phone> Phones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<User>().HasData(
				new User
				{
					Id=1,
					Name = "Ata"
				},
                new User
                {
                    Id = 2,
                    Name = "Cem abi"
                },
                new User
                {
                    Id = 3,
                    Name = "Faruk abi"
                }

                );

            modelBuilder.Entity<Phone>().HasData(
                new Phone
                {
                    Id = 1,
                    PhoneNumber = "555 55 55",
                    UserId=1
                },
                new Phone
                {
                    Id = 2,
                    PhoneNumber = "512355",
                    UserId = 1
                },
                new Phone
                {
                    Id = 3,
                    PhoneNumber = "33333",
                    UserId = 2
                },
                new Phone
                {
                    Id = 4,
                    PhoneNumber = "4444455",
                    UserId = 2
                },
                new Phone
                {
                    Id = 5,
                    PhoneNumber = "990900",
                    UserId = 3
                }
                );
        }


    }
}

