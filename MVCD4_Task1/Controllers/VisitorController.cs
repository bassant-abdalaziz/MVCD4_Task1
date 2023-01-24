using Microsoft.AspNetCore.Mvc;
using MVCD1.Models;

namespace MVCD1.Controllers
{
    public class VisitorController : Controller
    {
        public IActionResult RegisterForm()
        {
            return View("RegisterForm");
        }

        public IActionResult GetAllVisitors(Visitor visitor)
        {
            SampleData.AddVisitor(visitor);
            List<Visitor> visitors = SampleData.Visitors.Where(v => v.willAttend == "true").ToList();
            if (visitors.Count > 0)
            {
                return View("GetAll", visitors);
            }

            else
            {
                return Content("no");
            }
        }


        public IActionResult AddData(Visitor visitor)
        {
            SampleData.AddVisitor(visitor);
            if (visitor.willAttend == "true")
            {
                return View("Attend");

            }
            else
            {
                return View("noAttend");
            }
        }
    }
}
