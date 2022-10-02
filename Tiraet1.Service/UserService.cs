﻿using Tiraet1.Data;
using Tiraet1.Repo;

namespace Tiraet1.Service;

public class UserService:IUserService  
{
    private IRepository<User> userRepository;  
    private IRepository<UserProfile> userProfileRepository;  
  
    public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)  
    {  
        this.userRepository = userRepository;  
        this.userProfileRepository = userProfileRepository;  
    }  
  
    public IEnumerable<User> GetUsers()  
    {  
        return userRepository.GetAll();  
    }  
  
    public User GetUser(long id)  
    {  
        return userRepository.Get(id);  
    }  
  
    public void InsertUser(User user)  
    {  
        userRepository.Insert(user);  
    }  
    public void UpdateUser(User user)  
    {  
        userRepository.Update(user);  
    }  
  
    public void DeleteUser(long id)  
    {              
        UserProfile userProfile = userProfileRepository.Get(id);  
        userProfileRepository.Remove(userProfile);  
        User user = GetUser(id);  
        userRepository.Remove(user);  
        userRepository.SaveChanges();  
    }  
}