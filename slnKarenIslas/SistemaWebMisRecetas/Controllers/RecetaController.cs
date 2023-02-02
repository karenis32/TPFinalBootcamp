using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System;
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
                receta.FechaCreado = DateTime.Now;
                receta.FechaActualizado = DateTime.Now;
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

        //GET Receta/Edit
        [HttpGet]
        public ActionResult Editar(int id)
        {
            Receta receta = (from a in context.Recetas
                             where a.Id == id
                             select a).FirstOrDefault();
           
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Editar", receta);
            }

        }

        //POST Receta/Edit
        [HttpPost]
        public ActionResult Editar(int id, Receta receta)
        {

            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                receta.FechaActualizado = DateTime.Now;
                context.Recetas.Update(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // GET receta/delete/1
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", receta);
            }
        }

        //POST opera/delete/1
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
