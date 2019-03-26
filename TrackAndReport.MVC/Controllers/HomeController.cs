using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackAndReport.BusinessServices.BusinessService;
using TrackAndReport.DataModels;

namespace TrackAndReport.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            UserDetailBusinessService userDetailBusinessService = new UserDetailBusinessService();
            userDetailBusinessService.GetUserDetail(0, out TransactionalInformation transaction);
            ViewBag.Message = "Your application description page.";
            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}