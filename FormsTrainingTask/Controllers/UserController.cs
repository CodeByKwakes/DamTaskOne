using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormsTrainingTask.Models;

namespace FormsTrainingTask.Controllers
{
    public class UserController : Controller
    {
        static List<UserModel> users = new List<UserModel>();
        // GET: User
        public ActionResult Index()
        {
            return View(users);
        }
        // GET: User/Add
        public ActionResult UserAdd()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult UserAdd(UserModel u)
        {

           users.Add(u);

            return RedirectToAction("Index");
        }
    }
}