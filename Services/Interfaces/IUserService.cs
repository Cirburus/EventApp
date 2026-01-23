using EventsApp.Models;
using EventsApp.Models.DAT;

namespace EventsApp.Services.Interfaces;

public interface IUserService
{
    Task<int> CreateUser(User user);
    IQueryable<User> ReadUsersByIds(List<long> userId);
    IQueryable<User> ReadUsersByName(List<string> userNames);
    IQueryable<User> UpdateUser(User user);
    IQueryable<User> DeleteUser(int userId);
    
}