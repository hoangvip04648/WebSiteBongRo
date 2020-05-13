using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult slider()
        {
            var model = new sliderDAO().getAllSlider();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult boxes()
        {
            var model = new boxesDAO().getAllBoxes();
            return PartialView(model);
        }
        public ActionResult lastestProduct()
        {
            var model = new productDAO().getHomePageProduct();
            return PartialView(model);
        }


        [ChildActionOnly]
        public ActionResult header()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult footer()
        {
            var model = new product_typeDAO().getAllProductType();
            return PartialView(model);
        }

        public ActionResult About()
        {
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