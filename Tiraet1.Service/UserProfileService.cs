using Tiraet1.Data;
using Tiraet1.Repo;

namespace Tiraet1.Service;

public class UserProfileService : IUserProfileService
{
    private IRepository<UserProfile> userProfileRepository;  
  
    public UserProfileService(IRepository<UserProfile> userProfileRepository)  
    {             
        this.userProfileRepository = userProfileRepository;  
    }  
  
    public UserProfile GetUserProfile(long id)  
    {  
        return userProfileRepository.Get(id);  
    }  
}