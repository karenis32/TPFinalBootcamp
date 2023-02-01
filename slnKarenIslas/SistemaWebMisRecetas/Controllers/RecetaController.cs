using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DBRecetaContext context;

        public RecetaController(DBRecetaContext context)
        {
            this.context = context;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();

            return View(recetas);
        }

        //Get: Receta/create
        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create", receta);
        }

        //post: Receta/Create
        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        //GET Receta/Details/4
        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }

        }

        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }

        //GET Receta/ByNombreAutor/nombreAutor
        [HttpGet]
        public ActionResult ByNombreAutor(string autor)
        {
            var receta = (from a in context.Recetas
                          where a.Autor == autor
                          select a).ToList();
            return View("ByNombreAutor", receta);

        }
    }
}
