using EventsApp.Models;

namespace EventsApp.Services.Interfaces;

public interface IUserService
{
    DatUser CreateUser(DatUser user);
    IQueryable<DatUser> ReadUsersByIds(List<long> userId);
    IQueryable<DatUser> ReadUsersByName(List<string> userNames);
    IQueryable<DatUser> UpdateUser(DatUser user);
    IQueryable<DatUser> DeleteUser(int userId);
    
}