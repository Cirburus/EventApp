using EventsApp.Models;
using EventsApp.Models.DAT;

namespace EventsApp.Services.Interfaces;

public interface IUserService
{
    Task<List<User>> CreateUsers(List<User> users);
    IQueryable<User> ReadUsersByIds(List<long> userId);
    IQueryable<User> ReadUsersByName(List<string> userNames);
    Task<IQueryable<User>> UpdateUser(User user);
    Task<IQueryable<User>> DeleteUsers(int userId);
    
}