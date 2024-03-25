using CemPorcento.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CemPorcento.Controllers
{
	public class HomeController : Controller
	{
        public IActionResult Index() => View();

        [HttpGet("/kids")]
        public IActionResult Kids() => View();

        [HttpGet("/product")]
        public IActionResult Product() => View();


        [HttpGet("/ff")]
        public IActionResult footer() => View();
    }
}
