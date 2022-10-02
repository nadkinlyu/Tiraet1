using Tiraet1.Data;

namespace Tiraet1.Service;

public interface IUserProfileService
{
    UserProfile GetUserProfile(long id);  
}