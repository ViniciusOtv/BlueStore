using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class ErrorsController : BaseController
    {
        public ActionResult InternalServerError()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

    }
}