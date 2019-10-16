using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguimientoPaciente.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
		
		[HttpPost]
		public ActionResult validar(int e , string t) {

			/*var usuario = db.usuario.where(x=> x.pass == t && x.correo == e );
			var tipo = db.tipo.where(x => x.fkusu == usuario.id);
			if (usuario != null) {
				if (tipo.descripcion == 1)
				{


				}

			}*/
			return RedirectToAction("index", "Home");
		}
    }
}