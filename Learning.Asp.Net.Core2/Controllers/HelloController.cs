namespace Learning.Asp.Net.Core2.Controllers;

using Domain;
using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public HelloController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        return Content("Hello World.");
    }

    public IActionResult Greet()
    {
        ViewBag.Message = "こんにちは、世界！";
        return View();
    }

    public IActionResult List()
    {
        return View(_unitOfWork.BookRepository.GetAll());
    }
}