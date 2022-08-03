using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        Message newMessage = new Message()
        {
            Msg = "This is a message to test out the functionality of rendering a page with a string model!"
        };
        return View(newMessage);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        int[] numArray = new int[]
        {
            1, 2, 3, 10, 43, 5
        };
        return View(numArray);
    }

}
