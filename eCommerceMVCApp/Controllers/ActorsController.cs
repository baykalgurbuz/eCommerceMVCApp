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
            var data = await _services.GetAllAsync();
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
            await _services.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _services.ActorGetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _services.ActorGetByIdAsync(id);
            if (actorDetails == null) return View("Now Found");
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fullname,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.UpdateASync(id, actor);
            return RedirectToAction(nameof(Index));

        }

     
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _services.ActorGetByIdAsync(id);
            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);

        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _services.ActorGetByIdAsync(id);
            if (actorDetails == null) return View("Not Found");
            await _services.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
