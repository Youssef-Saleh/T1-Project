using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Beat.Interfaces;
using Beat.Model;
using Beat.Services;

namespace Beat.Controllers
{
    public class HomeController : Controller
    {
        private IMemberService _memberService;

        public HomeController()
        {
            _memberService = new MemberService();
        }
        public ActionResult Index()
        {
            var members = _memberService.GetAll();
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
