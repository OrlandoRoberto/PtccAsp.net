using Microsoft.AspNetCore.Mvc;
using PtccAsp.net.Models;
using System.Linq;

namespace PtccAsp.net.Controllers
{
    public class CadastroProdutoController : Controller
    {
        public static List<CadastroProduto> ProdutosSalvos = new List<CadastroProduto>();

        
        private bool UsuarioLogado()
        {
            return !string.IsNullOrEmpty(HttpContext.Session.GetString("UsuarioLogado"));
        }

        public IActionResult CadastroProduto()
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(CadastroProduto novoProduto)
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            if (ProdutosSalvos.Any(p =>
                p.NomeProduto.ToLower() == novoProduto.NomeProduto.ToLower() &&
                p.Categoria.ToLower() == novoProduto.Categoria.ToLower()))
            {
                TempData["Erro"] = "Produto já cadastrado nesta categoria!";
                return View("CadastroProduto", novoProduto);
            }

            novoProduto.IdProduto = ProdutosSalvos.Count + 1;  // ← ESTA LINHA FALTAVA!
            ProdutosSalvos.Add(novoProduto);                   // ← ESTA LINHA FALTAVA!
            TempData["Sucesso"] = "Produto cadastrado com sucesso!";  // ← ESTA LINHA FALTAVA!
            return RedirectToAction("CadastroProduto");
            }

        public IActionResult Editar(int id)
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            var produto = ProdutosSalvos.FirstOrDefault(p => p.IdProduto == id);
            if (produto == null)
            {
                TempData["Erro"] = "Produto não encontrado!";
                return RedirectToAction("ProdutosCadastrados", "ProdutosCadastrados");
            }

            return View("CadastroProduto", produto);
        }

        [HttpPost]
        public IActionResult Update(CadastroProduto produtoEditado)
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            var produtoAntigo = ProdutosSalvos.FirstOrDefault(p => p.IdProduto == produtoEditado.IdProduto);
            if (produtoAntigo == null)
            {
                TempData["Erro"] = "Produto não encontrado!";
                return RedirectToAction("ProdutosCadastrados", "ProdutosCadastrados");
            }

            // Atualiza os dados
            produtoAntigo.NomeProduto = produtoEditado.NomeProduto;
            produtoAntigo.Categoria = produtoEditado.Categoria;
            produtoAntigo.Preco = produtoEditado.Preco;

            TempData["Sucesso"] = "Produto atualizado com sucesso!";
            return RedirectToAction("ProdutosCadastrados", "ProdutosCadastrados");
        }
        public IActionResult Excluir(int id)
        {
            if (!UsuarioLogado())
            {
                return RedirectToAction("LoginFuncionario", "Login");
            }

            var produto = ProdutosSalvos.FirstOrDefault(p => p.IdProduto == id);
            if (produto != null)
                ProdutosSalvos.Remove(produto);

            return RedirectToAction("ProdutosCadastrados", "ProdutosCadastrados");
        }
    }
}