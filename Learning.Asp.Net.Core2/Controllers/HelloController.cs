﻿namespace Learning.Asp.Net.Core2.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
    public IActionResult Index()
    {
        return Content("Hello World.");
    }

    public IActionResult Greet()
    {
        ViewBag.Message = "こんにちは、世界！";
        return View();
    }
}