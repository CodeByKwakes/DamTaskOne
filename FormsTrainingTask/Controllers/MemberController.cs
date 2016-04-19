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
        // GET: Members
        private static Members members = new Members();
        public ActionResult Index()
        {
            return View(members.memberList);
        }
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(MemberModel memberModel)
        {
            members.CreateMember(memberModel);
            return View("Index", members.memberList);
        }
    }
}