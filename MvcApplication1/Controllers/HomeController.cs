using DatabaseBit.SomeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        SomeServiceOrSomething testService = new SomeServiceOrSomething();

        public ActionResult Index()
        {
            var words = testService.GetSomeWords().ToList();

            return View(words);
        }

        public ActionResult AddStuff()
        {
            testService.AddSomeData("i am some data");
            testService.AddSomeData("mooooooore data");

            return RedirectToAction("Index");
        }
    }
}
