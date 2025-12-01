using Microsoft.AspNetCore.Mvc;
using PtccAsp.net.Models;
using System.Linq;

namespace PtccAsp.net.Controllers
{
    public class ProdutosCadastradosController : Controller
    {
        
        private bool UsuarioLogado()
        {
            return !string.IsNullOrEmpty(HttpContext.Session.GetString("UsuarioLogado"));
        }

        public IActionResult ProdutosCadastrados()
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            var produtos = CadastroProdutoController.ProdutosSalvos ?? new List<CadastroProduto>();
            return View("ProdutosCadastrados", produtos);
        }
    }
}