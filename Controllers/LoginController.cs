using Microsoft.AspNetCore.Mvc;
using PtccAsp.net.Models;
using System.Linq;
namespace PtccAsp.net.Controllers
{
    public class LoginController : Controller
    {
        // Lista de usuários (em memória) - substituir por banco depois
        private static List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nome = "Administrador", Email = "admin@sistema.com", Senha = "300390" },
            new Usuario { Id = 2, Nome = "Wellington Cidade", Email = "wellington@cidade.com", Senha = "242424" }
        };

        // GET: Mostra o formulário de login
        public IActionResult LoginFuncionario()
        {
            return View();
        }

        // POST: Processa o login
        [HttpPost]
        public IActionResult Autenticar(Login login)
        {
            // Verifica se o usuário existe
            var usuario = Usuarios.FirstOrDefault(u => u.Email == login.Usuario && u.Senha == login.Senha);

            if (usuario != null)
            {
                // Login bem-sucedido - salva na sessão
                HttpContext.Session.SetString("UsuarioLogado", usuario.Nome);
                TempData["Sucesso"] = $"Bem-vindo, {usuario.Nome}!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Login falhou
                TempData["Erro"] = "Usuário ou senha inválidos!";
                return View("LoginFuncionario");
            }
        }

        // LOGOUT
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UsuarioLogado");
            TempData["Sucesso"] = "Logout realizado com sucesso!";
            return RedirectToAction("LoginFuncionario");
        }
    }
}