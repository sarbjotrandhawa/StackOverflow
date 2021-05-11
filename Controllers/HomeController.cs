using Assignment3_N01392504.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3_N01392504.Controllers
{
    public class HomeController : Controller
    {
        private QuestionContext db = new QuestionContext();
        public ActionResult Index()
        {
      //      var user = System.Web.HttpContext.Current.User.Identity.GetUserName();
            return View(db.Questions.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Categories()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Questions()
        {
            return RedirectToAction("Index", "Questions");
        }
    }
}