using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userid,int age)
        {
            if (userid == "kimo")
            {

                return Redirect("/home/test");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Test()
        {
            return View();
        }

        public IActionResult TestData()
        {
            ViewData["MyMsg"] = "Hello respone";
            ViewBag.Test=new List<string> { "a","b","c"};
            var list = new List<string>{"1","2","3"};
            return View(list);
        }
    }
}
