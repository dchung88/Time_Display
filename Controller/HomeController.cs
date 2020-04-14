using Microsoft.AspNetCore.Mvc;

namespace Time_Display
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
    }
}