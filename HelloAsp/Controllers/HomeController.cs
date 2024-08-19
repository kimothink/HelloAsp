using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string? userid = Request.Query["user_id"];
            string? age = Request.Query["age"];
            return "닷넷 오픈채팅방 화이팅!!."+userid+age;
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
