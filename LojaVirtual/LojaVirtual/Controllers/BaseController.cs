using LojaVirtual.DAL;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDbContext 
            _dal = new ApplicationDbContext();


        protected override void OnActionExecuting(
            ActionExecutingContext filterContext)
        {
            ViewBag.Carrinho = GetCarrinho();
            ViewBag.Categorias = _dal.Categorias.ToArray();

            base.OnActionExecuting(filterContext);
        }

        public Carrinho GetCarrinho()
        {
            if (Session["carrinho"] == null)
            {
                Session["carrinho"] = new Carrinho();
            }
            return (Carrinho)Session["carrinho"];
        }
    }
}