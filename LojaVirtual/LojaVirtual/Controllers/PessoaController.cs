using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class PessoaController : BaseController
    {
        // GET: Pessoa
        public ActionResult Eu(string id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult Voce()
        {
            return View();
        }
    }
}