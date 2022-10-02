using Microsoft.EntityFrameworkCore;
using Tiraet1.Data;

namespace Tiraet1.Repo;

public class AplicationContext:DbContext
{
    public AplicationContext(DbContextOptions<AplicationContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder model)
    {
        base.OnModelCreating(model);
        new UserMap(model.Entity<User>());
        new UserProfileMap(model.Entity<UserProfile>());

    }
    
    
}