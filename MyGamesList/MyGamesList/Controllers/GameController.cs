using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGamesList.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}