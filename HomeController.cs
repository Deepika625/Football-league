using Football_League.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Football_League.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext context = new MyDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(context.matches);
        }
    }
}