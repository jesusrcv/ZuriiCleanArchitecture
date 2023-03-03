using Microsoft.AspNetCore.Mvc;
using Zurii_Core.Interfaces;
using Zurii_Core.Models;

namespace ZuriiApplication.Controllers;

[ApiController]
[Route("[controller]")]

public class AccountsController : ControllerBase
{
    public IUserService _userService;

    public AccountsController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost("/User")]
    public async Task<IActionResult> CreateUser(User user)
    {
        //crear usuario
        var flag = await _userService
    }
}