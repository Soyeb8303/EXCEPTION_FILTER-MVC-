using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIRST_FILTER.Controllers
{
    //[HandleError]
    public class HomeController : Controller
    {
        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            try
            {
                int a = 10;
                int b = a / 2;
              
                return View();
            }
            catch
            {
                throw new Exception();
               // return View();
            }
          
        }

        [HandleError(View = "Error")]
        public ActionResult About()
        {
            throw new Exception();
           // return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}