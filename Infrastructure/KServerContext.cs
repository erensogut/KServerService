
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KServerService.Infrastructure
{
	public class KserverContext : IdentityDbContext<IdentityUser>
    {
        public KserverContext(DbContextOptions<KserverContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedUsers(builder);
        }

        public DbSet<Domain.File> Files { get; set; }

        private void SeedUsers(ModelBuilder builder)
        {
            
            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();


            //Seeding the User to AspNetUsers table
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "firstUser",
                    NormalizedUserName = "MYUSER",
                    Email = "admin@kserver.com",
                    PasswordHash = hasher.HashPassword(null, "String1@")
                }
            );
        }
    }
}

