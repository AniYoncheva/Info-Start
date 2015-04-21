using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDiary.Controllers
{
    public class MyselfController : Controller
    {
        // GET: Myself
        public ActionResult AboutMe()
        {
            return View();
        }
    }
}