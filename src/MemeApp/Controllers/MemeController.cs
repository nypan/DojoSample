using MemeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MemeApp.Controllers
{
    public class MemeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MemeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            var memeUrl = "https://api.imgflip.com/get_memes";
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync(memeUrl);
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();
                Memes? memes =JsonSerializer.Deserialize<Memes>(json);
                return View(memes);
            }
            throw new Exception($"API anrop fel {result.StatusCode}");
            
        }
    }
}
