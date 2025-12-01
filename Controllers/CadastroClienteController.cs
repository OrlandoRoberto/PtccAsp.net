using Microsoft.AspNetCore.Mvc;

namespace PtccAsp.net.Controllers
{
    public class CadastroClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
    }
}
