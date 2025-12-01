using Microsoft.AspNetCore.Mvc;
using PtccAsp.net.Models;
using System.Linq;

namespace PtccAsp.net.Controllers
{
    public class ClienteController : Controller
    {
        public static List<Cliente> ClientesSalvos = new List<Cliente>();

        
        private bool UsuarioLogado()
        {
            return !string.IsNullOrEmpty(HttpContext.Session.GetString("UsuarioLogado"));
        }

        public IActionResult Cliente()
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }
            return View("~/Views/CadastroCliente/CadastroCliente.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Cliente novoCliente)
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            if (ClientesSalvos.Any(c =>
                c.Nome.ToLower() == novoCliente.Nome.ToLower() &&
                c.Email.ToLower() == novoCliente.Email.ToLower()))
            {
                TempData["Erro"] = "Cliente já cadastrado no sistema!";
                return View("~/Views/CadastroCliente/CadastroCliente.cshtml", novoCliente);
            }

            novoCliente.Id = ClientesSalvos.Count + 1;
            ClientesSalvos.Add(novoCliente);
            TempData["Sucesso"] = "Cliente cadastrado com sucesso!";
            return RedirectToAction("Cliente");
        }

        public IActionResult Lista()
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            var clientes = ClientesSalvos ?? new List<Cliente>();
            return View("~/Views/Cliente/Cliente.cshtml", clientes);
        }

        public IActionResult Excluir(int id)
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            var cliente = ClientesSalvos.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
                ClientesSalvos.Remove(cliente);

            return RedirectToAction("Lista");
        }
    }
}