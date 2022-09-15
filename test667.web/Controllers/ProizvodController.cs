using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using test667.web.Models;
using test667.data.Services;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using test667.data.Models;

namespace test667.web.Controllers
{
    public class ProizvodController : Controller
    {
        private readonly IProizvodData db;

        public ProizvodController(IProizvodData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Тука може да ја погледнете палетата на производи на Маган-Мак";
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Index1()
        {
            ViewBag.Message = "Тука може да ја погледнете палетата на производи на Маган-Мак";
            var model = db.GetAll();
            return View(model);
        }
        public ActionResult Detali(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model); 
        }

        public ActionResult Detali1(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            ViewBag.Message = "Детали за " + model.ime;
            return View(model);
        }

        public ActionResult nov_proizvod()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nov_proizvod(Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                TempData["izvestuvanje"] = "Производот е успешно додаден";
                db.Add(proizvod);
                return RedirectToAction("Detali", new { id = proizvod.Id });
            }
            return View();
        }

        [HttpGet]
        public ActionResult Izmeni(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izmeni (Proizvod proizvod)
        {
            if (ModelState.IsValid) 
            {
                TempData["izvestuvanje"] = "Производот е успешно изменет";
                db.Update(proizvod);

                return RedirectToAction("Detali", new { id = proizvod.Id });
            }
            return View(proizvod);
        }

        [HttpGet]
        public ActionResult Izbrishi(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izbrishi(int id, FormCollection form)
        {
            TempData["izvestuvanje"] = "Производот е успешно избришан!";
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
