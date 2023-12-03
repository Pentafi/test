//using Microsoft.AspNetCore.Mvc;

//namespace ASI.Basecode.WebApp.Controllers
//{
//    public class AdminController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View(); // This will render Views/Admin/Index.cshtml
//        }
//    }
//}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static ASI.Basecode.Resources.Constants.Constants;

namespace ASI.Basecode.WebApp.Controllers
{ 

    [Authorize( Roles = "DESKTOP-6IUT334\\joshu")]

    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
