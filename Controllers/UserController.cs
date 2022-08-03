using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class UserController : Controller
{
    [HttpGet("/users")]
    public IActionResult UserList()
    {
        string[] userList = new string[]
        {
            "Eren Yeager",
            "Reiner Braun",
            "Mikasa Ackermann",
            "Armin Arlert"
        };
        return View(userList);
    }

    [HttpGet("/user")]
    public new IActionResult User()
    {
        User newUser = new User()
        {
            FirstName = "Eren",
            LastName = "Yeager"
        };
        return View(newUser);
    }

}
