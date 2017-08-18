using MoviesMais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesMais.Controllers
{
    public class CategoriaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inserir()
        {
            return View();
        }

        public RedirectToRouteResult Salvar(Categoria categoria)
        {
            int codigoGerado = categoria.InserirCategoria(categoria);
            
            return RedirectToAction("Index");
        }
    }
}