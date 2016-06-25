using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProbandoLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Ingresar(Models.usuario usuario)
        {
            Repository.LoginRepository lr = new Repository.LoginRepository();
            Models.usuario logueado = lr.ingresar(usuario);

            if (logueado == null)
            {
                ViewBag.Error = "El usuario " + usuario.usuario1 + " no existe o la contraseña " + usuario.clave + " es incorrecta.";
                return View("Index");
            }
            else
            {
                return View();
            }
        }
    }
}