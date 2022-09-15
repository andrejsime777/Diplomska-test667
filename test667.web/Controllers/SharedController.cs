using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using test667.data.Services;

namespace test667.web.Controllers
{
    public class SharedController : Controller
    {

        private readonly IBrzLinkData db;

        public SharedController(IBrzLinkData db)
        {
            this.db = db;
        }

        public ActionResult _Layout()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}