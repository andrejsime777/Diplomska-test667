using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test667.data.Models;
using test667.data.Services;
using test667.web.ViewModels;

namespace test667.web.Controllers
{
    public class ProgramController : Controller
    {
        private readonly IProgramData db;
        private readonly IKategorijaProgramiData dbktg;


        public ProgramController(IProgramData db, IKategorijaProgramiData dbktg)
        {
            this.db = db;
            this.dbktg = dbktg;
        }

        public ViewResult List()
        {
            ViewBag.Message = "Кликнете некоја од програмите за да видите повеќе информации";
            ProgramiListViewModel programiView = new ProgramiListViewModel();
            programiView.Programi = db.SiteProgrami;
            programiView.CurrentCategory = "Програми за заштита";
            return View(programiView);
        }

        public ViewResult List1()
        {
            ViewBag.Message = "Креирање и измена на програми";
            var programiView = new ProgramiListViewModel();
            programiView.Programi = db.SiteProgrami;
            programiView.Kategorija = dbktg.SiteKategorii;
            programiView.CurrentCategory = "Програми за заштита";
            

            /*var model = db.GetAll();*/
            return View(programiView);
        }

        public ActionResult nov_program()
        {
            ViewBag.Message = "Додади нов програм";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nov_program(Program program)
        {
            if (ModelState.IsValid)
            {
                db.Add(program);
                TempData["izvestuvanje"] = "Програмот е успешно додаден";
                return RedirectToAction("List1");
            }
            return View();
        }

        public ActionResult nova_kategorija()
        {
            ViewBag.Message = "Додади нова категорија на програми";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nova_kategorija(Kategorija_Programi kategorija)
        {
            if (ModelState.IsValid)
            {
                dbktg.Add(kategorija);
                TempData["izvestuvanje"] = "Категоријата е успешно додадена";
                return RedirectToAction("List1");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Izmeni(int id)
        {
            var getlist = dbktg.SiteKategorii.ToList();
            SelectList list = new SelectList(getlist, "KategorijaId", "KategorijaIme");
            ViewBag.list = list;

            var model = db.GetProgramById(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izmeni(Program program)
        {
            if (ModelState.IsValid)
            {
                program.kategorija_programi_KategorijaId = program.kategorija_programi.KategorijaId;
                db.Update(program);
                TempData["izvestuvanje"] = "Програмата е успешно изменета";
                return RedirectToAction("List1");
            }
            return View(program);
        }

        public ActionResult Izmeni_kategorija(int id)
        {
            var model = dbktg.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            ViewBag.Message = "Промена на поставките на категорија на програми";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izmeni_kategorija(Kategorija_Programi kategorija)
        {
            if (ModelState.IsValid)
            {
                TempData["izvestuvanje"] = "Категоријата е успешно изменета";
                dbktg.Update(kategorija);
                return RedirectToAction("List1");
            }
            return View(kategorija);
        }

        [HttpGet]
        public ActionResult Izbrishi(int id)
        {
            var model = db.GetProgramById(id);
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
            db.Delete(id);
            TempData["izvestuvanje"] = "Програмот е успешно избришан";
            return RedirectToAction("List1");
        }

        [HttpGet]
        public ActionResult Izbrishi_kategorija(int id)
        {
            var model = dbktg.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izbrishi_kategorija(int id, FormCollection form)
        {
            TempData["izvestuvanje"] = "Категоријата е успешно избришана!";
            dbktg.Delete(id);
            return RedirectToAction("List1");
        }
    }
}