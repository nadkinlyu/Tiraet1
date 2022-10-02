using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Tiraet1.Data;
public class UserProfileMap 
{
    public UserProfileMap(EntityTypeBuilder<UserProfile> entityBuilder)
    {
        entityBuilder.HasKey(t => t.ID);
        entityBuilder.Property(t => t.FirstName).IsRequired();
        entityBuilder.Property(t => t.LastName).IsRequired();
        entityBuilder.Property(t => t.IPAddress);
    }

}