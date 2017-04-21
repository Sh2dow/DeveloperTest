using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeveloperTest.Controllers
{
    public class ErrorController : Controller
    {
        #region Public Methods

        //
        // GET: /Error/NotFound/
        public ActionResult NotFound()
        {
            return View("NotFound");
        }

        //
        // GET: /Error/Unknown/
        public ActionResult Unknown()
        {
                return View("Unknown");
        }

        #endregion
    }
}