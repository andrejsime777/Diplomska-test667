using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test667.data.Models;
using test667.data.Services;

namespace test667.web.Controllers
{
    public class BrzLinkController : Controller
    {
        private readonly IBrzLinkData db;

        public BrzLinkController(IBrzLinkData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            /*ViewBag.Message = "Страна за преглед и промена на брзи линкови";*/
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult nov_link()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nov_link(Brz_link brz_link)
        {
            if (ModelState.IsValid)
            {
                db.Add(brz_link);
                ViewBag.news = "Линкот е успешно додаден";
                return RedirectToAction("Index");
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
        public ActionResult Izmeni(Brz_link brz_link)
        {
            if (ModelState.IsValid)
            {
                db.Update(brz_link);

                ViewBag.news = "Линкот е успешно изменет";
                return RedirectToAction("Index");
            }
            return View(brz_link);
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
            db.Delete(id);
            ViewBag.news = "Линкот е успешно избришан";
            return RedirectToAction("Index");
        }
    }
}