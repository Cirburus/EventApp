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
    public IActionResult AddUser([FromBody] User user)
    {
        return Ok(userService.CreateUser(user));
    }
    [HttpDelete("remove")]
    public IActionResult AddUser([FromBody] int userId)
    {
        return Ok(userService.DeleteUser(userId));
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