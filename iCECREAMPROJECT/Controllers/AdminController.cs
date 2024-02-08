using iCECREAMPROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iCECREAMPROJECT.Controllers
{
    public class AdminController : Controller
    {
        ICECREAMPROJECTEntities db = new ICECREAMPROJECTEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View(db.tbl_feedback.ToList().OrderByDescending(x=>x.f_id));
        }
    }
}