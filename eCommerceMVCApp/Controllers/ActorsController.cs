using eCommerceMVCApp.Data;
using eCommerceMVCApp.Data.Services;
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
    }
}
