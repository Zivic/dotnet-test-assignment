using System.Diagnostics;
using DogProject.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using DogProject.Models;

namespace DogProject.Controllers;

public class DogController : Controller
{
    private readonly ILogger<DogController> _logger;
    private readonly HttpClient _httpClient;

    public DogController(HttpClient httpClient, ILogger<DogController> logger )
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    [Route("/dogs")]
    [HttpGet]
    public Task<IActionResult> Get(QueryModels.GetAllTerrierDogs request)
    {
        return RequestHandler.HandleQuery(() => Queries.Query(request), _logger);
    }
    
    //nije trazeno u zadatku ali sluzi da demonstrira reusability - izmene koda nisu bile neophodne i svaki kontroler u principu zove istu funkciju
    [Route("/dogs/all")]
    [HttpGet]
    public Task<IActionResult> Get(QueryModels.GetAllDogNames request)
    {
        return RequestHandler.HandleQuery(() => Queries.Query(request), _logger);
    }

    public async Task<IActionResult> Index()
    {
        var result = await Get(new QueryModels.GetAllTerrierDogs());
        var a = (result as OkObjectResult)?.Value as ReadModels.DogNames;
        var dogList = a.DogNamesList;
        return View(dogList);
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