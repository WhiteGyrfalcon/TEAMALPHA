using FunnyBunnyGames.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunnyBunnyGames.Data.Data.Configuration
{
    internal class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User()
            {
                Id = Guid.Parse("361fbf2d-ade9-4858-be97-a1795b723c62"),
                FirstName = "Stela",
                LastName = "Fox",
                Age = 20,
                UserName = "StelaFox",
                Email = "stelafox@gmail.com",
                PhoneNumber = "089 111 1111",
                
            });
   
            builder.HasData(new User()
            {
                Id = Guid.Parse("1c77b562-e54d-4944-97f7-88717b6ac76a"),
                FirstName = "John",
                LastName = "Smith",
                Age = 18,
                UserName = "JoshnSmith",
                Email = "johnsmith@gmail.com",
                PhoneNumber = "089 222 2222",
                
            });                 
        }
    }
}
