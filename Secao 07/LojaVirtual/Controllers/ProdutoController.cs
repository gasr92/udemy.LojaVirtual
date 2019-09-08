using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Visualizar()
        {
            // return new ContentResult(){
            //     Content = "<h3>Produto -> visualizar</h3>",
            //     ContentType = "text/html"
            // };

            var produto = GetProduto();
            return View(produto);
        }

        private Produto GetProduto()
        {
            return new Produto(){   
                Id = 1,
                Nome = "XBox One",
                Descricao = "Jogue em 4k",
                Valor = 2000.90M
            };
        }
    }
}