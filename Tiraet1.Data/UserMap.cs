using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Tiraet1.Data;
public class UserMap 
{
    public UserMap(EntityTypeBuilder<User> entityBuilder)
    {
        entityBuilder.HasKey(t => t.ID);
        entityBuilder.Property(t => t.Email).IsRequired();
        entityBuilder.Property(t => t.Password).IsRequired();
        entityBuilder.Property(t => t.UserName).IsRequired();
        entityBuilder.HasOne(t => t.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.ID);
    }

}