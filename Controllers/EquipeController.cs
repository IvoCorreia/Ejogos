using Ejogos.Models;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Cadastrar(IFormCollection form)                   {

            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(form["id"]);
            nova_equipe.Nome = (form["nome"]);
            nova_equipe.Imagem = (form["imagem"]);
            /*
                        nova_equipe.
            */
            
            equipeModel.Create(nova_equipe);


            ViewBag.Equipes = equipeModel.ReadAll();

            return LocalRedirect("~/Equipe");

        }

    }
}
