using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test667.data.Services;

namespace test667.web.Controllers
{
    public class HomeController : Controller
    {
        IProizvodData db;
        IBrzLinkData db1;

        public HomeController(IBrzLinkData db1, IProizvodData db)
        {
            this.db = db;
            this.db1 = db1;
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            var model1 = db1.GetAll();
            ViewBag.Message = "Инфо за Маган-Мак";

            return View(model1);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Тука можете да не контактирате";

            return View();
        }
    }
}