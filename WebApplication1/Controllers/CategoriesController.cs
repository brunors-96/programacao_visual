using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Categorie> categories = new List<Categorie>()
        {
            new Categorie()
            {
                CategorieId=1,
                Nome="Notebooks"
            },
            new Categorie()
            {
                CategorieId=2,
                Nome="Monitores"
            },
            new Categorie()
            {
                CategorieId=3,
                Nome="Impressoras"
            },
            new Categorie()
            {
                CategorieId=4,
                Nome="Mouses"
            },
            new Categorie()
            {
                CategorieId=5,
                Nome="Desktops"
            },
        };

        // GET: Categories
        public ActionResult Index()
        {
            return View(categories);
        }
        
        // GET: Creat
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorie categorie)
        {
            categories.Add(categorie);
            categorie.CategorieId = categories.Select(m => m.CategorieId).Max() + 1;
            return RedirectToAction("Index");
        } 
        
        public ActionResult Edit(long id)
        {
            return View(categories.Where(m => m.CategorieId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorie categorie)
        {
            categories.Remove(categories.Where(c => c.CategorieId == categorie.CategorieId).First());
            categories.Add(categorie);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(categories.Where(m => m.CategorieId == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(categories.Where(m => m.CategorieId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categorie categorie)
        {
            categories.Remove(categories.Where(c => c.CategorieId == categorie.CategorieId).First());
            return RedirectToAction("Index");
        }
    }
}