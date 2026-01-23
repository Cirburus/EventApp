using EventsApp.Models;
using EventsApp.Models.DAT;
using EventsApp.Services.Interfaces;

namespace EventsApp.Services;

public class UserService(SnowflakeContext snowflakeContext): IUserService
{
    public Task<int> CreateUser(User user)
    {
        snowflakeContext.Users.Add(user);
        
        return snowflakeContext.SaveChangesAsync();
    }

    public IQueryable<User> ReadUsersByIds(List<long> userIds)
    {
        return snowflakeContext.Users.Where(datUser => userIds.Contains<long>(datUser.UserId));
    }

    public IQueryable<User> ReadUsersByName(List<string> userNames)
    {
        return snowflakeContext.Users.Where(datUser => userNames.Contains(datUser.FName??"") || userNames.Contains(datUser.LName));
    }

    public IQueryable<User> UpdateUser(User user)
    {
        var usersToUpdate = snowflakeContext.Users.Where(datUser => user.UserId.Equals(datUser.UserId));
        foreach (var datUser in usersToUpdate)
        {
            datUser.FName = user.FName;
            datUser.LName = user.LName;
        }

        snowflakeContext.SaveChanges();
        
        return usersToUpdate;
    }

    public IQueryable<User> DeleteUser(int userId)
    {
        var usersToDelete = snowflakeContext.Users.Where(datUser => datUser.UserId.Equals(userId));
        foreach (var datUser in usersToDelete)
        {
            snowflakeContext.Users.RemoveRange(datUser);
        }

        snowflakeContext.SaveChanges();
        
        return usersToDelete;
    }
}