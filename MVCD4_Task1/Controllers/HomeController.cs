using Microsoft.AspNetCore.Mvc;

namespace MVCD1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
           return View ("information");
        }
    }
}
