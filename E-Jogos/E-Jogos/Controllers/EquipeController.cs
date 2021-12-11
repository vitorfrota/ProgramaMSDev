using E_Jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Jogos.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {
            // VIEWBAG ARMAZENA AS INFORMAÇÕES DO BACKEND PARA SEREM ACESSADAS NO FRONTEND.
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            // VIEWBAG ARMAZENA AS INFORMAÇÕES DO BACKEND PARA SEREM ACESSADAS NO FRONTEND.
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }
    }
}
