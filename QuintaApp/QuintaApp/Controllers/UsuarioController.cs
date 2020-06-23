using QuintaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuintaApp.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            Usuario usu = new Usuario()
            {
                UsuId = 0,
                UsuNome = "Digite um nome",
                UsuObs = "Digite uma Observação",
                UsuNasc = Convert.ToDateTime("01/05/2000"),
                UsuEmail = "Digite um email",
                UsuLogin = "Digite um login",
                UsuSenha = 12345678,
                UsuConfirmarSenha = 12345678 

            };
            return View(usu);
        }

        [HttpPost]
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
          
            return View(usuario);
        }
    }
}