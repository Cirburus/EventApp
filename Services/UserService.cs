using EventsApp.Models;
using EventsApp.Services.Interfaces;

namespace EventsApp.Services;

public class UserService(SnowflakeContext snowflakeContext): IUserService
{
    public DatUser CreateUser(DatUser user)
    {
        snowflakeContext.DatUsers.Add(user);
        
        snowflakeContext.SaveChanges();
        
        return user;
    }

    public IQueryable<DatUser> ReadUsersByIds(List<long> userIds)
    {
        return snowflakeContext.DatUsers.Where(datUser => userIds.Contains<long>(datUser.Userid));
    }

    public IQueryable<DatUser> ReadUsersByName(List<string> userNames)
    {
        return snowflakeContext.DatUsers.Where(datUser => userNames.Contains(datUser.Fname??"") || userNames.Contains(datUser.Lname));
    }

    public IQueryable<DatUser> UpdateUser(DatUser user)
    {
        var usersToUpdate = snowflakeContext.DatUsers.Where(datUser => user.Userid.Equals(datUser.Userid));
        foreach (var datUser in usersToUpdate)
        {
            datUser.Fname = user.Fname;
            datUser.Lname = user.Lname;
        }

        snowflakeContext.SaveChanges();
        
        return usersToUpdate;
    }

    public IQueryable<DatUser> DeleteUser(int userId)
    {
        var usersToDelete = snowflakeContext.DatUsers.Where(datUser => datUser.Userid.Equals(userId));
        foreach (var datUser in usersToDelete)
        {
            snowflakeContext.DatUsers.RemoveRange(datUser);
        }

        snowflakeContext.SaveChanges();
        
        return usersToDelete;
    }
}