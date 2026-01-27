using EventsApp.Models;
using EventsApp.Models.DAT;
using EventsApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Controllers;

/// <summary>
/// Manage users
/// </summary>
/// <param name="userService"></param>
[ApiController]
[Route("api/v1/user")]
public class UserController(IUserService userService) : ControllerBase
{
    /// <summary>
    /// Add a user to the Data base
    /// </summary>
    /// <param name="users"></param>
    /// <returns>The user which was added.</returns>
    [HttpPost]
    public async Task<IActionResult> AddUsers([FromBody] List<User> users)
    {
        var result = await userService.CreateUsers(users);
        return  Ok(result);
    }
    /// <summary>
    /// Remove a number of users from the Data base
    /// </summary>
    /// <param name="userIds"></param>
    /// <returns>A list of the users which were removed.</returns>
    [HttpDelete]
    public async Task<IActionResult> RemoveUsers([FromBody] List<int> userIds)
    {
        var result = await userService.DeleteUsers(userIds);
        return Ok(result);
    }
    /// <summary>
    /// Get a list of users by a list of ids (Should be a GET)
    /// </summary>
    /// <param name="userIds"></param>
    /// <returns></returns>
    [HttpPost("ById")]
    public IActionResult GetUsersById([FromBody] List<long> userIds)
    {
        return Ok(userService.ReadUsersByIds(userIds));
    }
    /// <summary>
    /// Return all users which have a matching Name (First or Last) (Should be a GET)
    /// </summary>
    /// <param name="userNames"></param>
    /// <returns>A List of users which have matching FName or LName to one in the list</returns>
    [HttpPost("ByName")]
    public IActionResult GetUsersByName([FromBody] List<string> userNames)
    {
        return Ok(userService.ReadUsersByName(userNames));
    }
    /// <summary>
    /// Update users, setting their names (First, Last or Both) to the values provided
    /// </summary>
    /// <param name="users"></param>
    /// <returns>A List of users which were updated and the state they are in now</returns>
    [HttpPatch]
    public async Task<IActionResult> UpdateUser([FromBody] List<User> users)
    {
        var result = await userService.UpdateUsers(users);
        return Ok(result);
    }
}