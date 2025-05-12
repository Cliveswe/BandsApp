using Microsoft.AspNetCore.Mvc;
using BandsApp.Web.Services;
using BandsApp.Web.Models;

namespace BandsApp.Web.Controllers
{
    public class BandsController : Controller
    {
        BandService bandService = new();
        [Route("")]
        public IActionResult Index()
        {
            Band[] model = bandService.GetAll();
            return View(model);
        }

        





    }
}
