using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormsTrainingTask.Models;

namespace FormsTrainingTask.Controllers
{
    public class MemberController : Controller
    {
        static List<MemberModel> members = new List<MemberModel>();
        // GET: Members
        //private static Members members = new Members();
        public ActionResult Index()
        {
            return View(members);
        }
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(MemberModel m)
        {

            if (!ModelState.IsValid)
            {
                return View("AddMember", m);
            }

            members.Add(m);
            return RedirectToAction("Index");
        }
    }
}