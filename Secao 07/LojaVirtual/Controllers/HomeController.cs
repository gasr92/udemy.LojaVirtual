using System;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }


        public IActionResult ContatoAcao()
        {
            try
            {
                var contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                //ContatoEmail.EnviarContatoPorEmail(contato);                

                // return new ContentResult(){
                //     Content = "Dados reecebidos com sucesso"
                // };

                var listaMsg = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                var ehValido = Validator.TryValidateObject(contato, contexto, listaMsg, true);

                if(ehValido)
                {
                    ViewData["MSG_S"] = "Mensagem enviada com sucesso";
                }
                else
                {
                    var sb = new StringBuilder();

                    foreach(var erro in listaMsg)
                    {
                        sb.Append(erro.ErrorMessage);
                    }

                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }


                return View("Contato");

            }catch(Exception e)
            {
                var msg = "Erro ao salvar o contato:\r\n" + e.Message;
                ViewData["MSG_E"] = msg;

                return View("Contato");
                // return new ContentResult(){
                //     Content = "Erro ao salvar o contato:\r\n" + e.Message
                // };
            }
        }
    }
}