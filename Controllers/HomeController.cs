using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PtccAsp.net.Models;

namespace PtccAsp.net.Controllers
{
    public class HomeController : Controller
    {
        
        private bool UsuarioLogado()
        {
            return !string.IsNullOrEmpty(HttpContext.Session.GetString("UsuarioLogado"));
        }

        public IActionResult Index()
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}