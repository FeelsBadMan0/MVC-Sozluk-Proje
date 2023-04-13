using MvcProjeKampi.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }


        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "Dizi",
                CategoryCount = 8
            });

            ct.Add(new CategoryClass()
            {
                CategoryName = "Film",
                CategoryCount = 4
            });

            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 5
            });

            ct.Add(new CategoryClass()
            {
                CategoryName = "Sosyal Medya",
                CategoryCount = 2
            });

            return ct;
        }
    }
}