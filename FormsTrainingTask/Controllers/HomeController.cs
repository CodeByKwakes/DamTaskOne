using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsTrainingTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SimpleForm()
        {
            return View();
        }
 
        [HttpPost]
        public ActionResult SimpleForm(FormCollection formCollection)
        {
            // ViewData["firstname"] = formCollection["firstname"];
            // ViewData["lastname"] = formCollection["lastname"];

            foreach (string _formData in formCollection)
            {
                ViewData[_formData] = formCollection[_formData];
            }

            return View();
        }


        public ActionResult Razor()
        {
            return View();
        }
        public ActionResult UserForm()
        {
            return RedirectToAction("Index", "User");
        }

        public ActionResult MembershipForm()
        {
            return RedirectToAction("Index", "Member");
        }

    }
}