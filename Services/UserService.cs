using EventsApp.Models;
using EventsApp.Models.DAT;
using EventsApp.Services.Interfaces;

namespace EventsApp.Services;

public class UserService(SnowflakeContext snowflakeContext): IUserService
{
    public async Task<List<User>> CreateUsers(List<User> users)
    {
        foreach (var user in users)
        {
            snowflakeContext.Users.Add(user);
        }
        
        await snowflakeContext.SaveChangesAsync();    

        return users;
    }

    public IQueryable<User> ReadUsersByIds(List<long> userIds)
    {
        return snowflakeContext.Users.Where(datUser => userIds.Contains<long>(datUser.UserId));
    }

    public IQueryable<User> ReadUsersByName(List<string> userNames)
    {
        return snowflakeContext.Users.Where(datUser => userNames.Contains(datUser.FName??"") || userNames.Contains(datUser.LName));
    }

    public async Task<IQueryable<User>> UpdateUsers(List<User> users)
    {
        var usersToUpdate = snowflakeContext.Users.Where(u => users.Select(i => i.UserId).Contains(u.UserId));

        foreach (var datUser in usersToUpdate)
        {
            datUser.FName = users.Where(user => user.UserId.Equals(datUser.UserId)).FirstOrDefault().FName;
            datUser.LName = users.Where(user => user.UserId.Equals(datUser.UserId)).FirstOrDefault().LName;
        }

        await snowflakeContext.SaveChangesAsync();
        
        return usersToUpdate;
    }

    public async Task<IQueryable<User>> DeleteUsers(List<int> userId)
    {
        var usersToDelete = snowflakeContext.Users.Where(datUser => datUser.UserId.Equals(userId));
        foreach (var datUser in usersToDelete)
        {
            snowflakeContext.Users.RemoveRange(datUser);
        }

        await snowflakeContext.SaveChangesAsync();
        
        return usersToDelete;
    }
}