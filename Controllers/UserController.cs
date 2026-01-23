using EventsApp.Models;
using EventsApp.Models.DAT;
using EventsApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.Controllers;

[ApiController]
[Route("api/v1/user")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost("add")]
    public async Task<IActionResult> AddUsers([FromBody] List<User> user)
    {
        var result = await userService.CreateUsers(user);
        return  Ok(result);
    }
    [HttpDelete("remove")]
    public async Task<IActionResult> RemoveUsers([FromBody] int userId)
    {
        var result = await userService.DeleteUsers(userId);
        return Ok(result);
    }
    [HttpGet("getUsersById")]
    public IActionResult GetUsersById([FromBody] List<long> userId)
    {
        return Ok(userService.ReadUsersByIds(userId));
    }
    [HttpGet("getUsersByName")]
    public IActionResult GetUsersByName([FromBody] List<string> userNames)
    {
        return Ok(userService.ReadUsersByName(userNames));
    }
    [HttpPut("update")]
    public IActionResult UpdateUser([FromBody] User user)
    {
        return Ok(userService.UpdateUser(user));
    }
}