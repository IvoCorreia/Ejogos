using Ejogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejogos.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {

            ViewBag.Equipes = equipeModel.ReadAll();


            

            return View();
        }
    }
}
