using BandsApp.Web.Models;
using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

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
        [Route("/details/{id}")]
        public IActionResult Details(int id)
        {
            var res = bandService.GetById(id);
            return View(res);
        }
    }
}
