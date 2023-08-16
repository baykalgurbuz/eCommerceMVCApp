using eCommerceMVCApp.Data;
using eCommerceMVCApp.Data.Services;
using eCommerceMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceMVCApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorServices _services;
        public ActorsController(IActorServices services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _services.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            _services.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
