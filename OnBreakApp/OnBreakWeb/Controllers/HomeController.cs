using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnBreakWeb.Models;
using Newtonsoft.Json;

using Models;

namespace OnBreakWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private HttpClient _httpClient;
    public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
    {
        _httpClient = httpClient;
        _logger = logger;

    }

    public async Task<ActionResult> Index()
    {
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
