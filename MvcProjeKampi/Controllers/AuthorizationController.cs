using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager am = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminValues = am.GetList();

            return View(adminValues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            am.AdminAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminValue = am.GetByID(id);
            return View(adminValue);
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            am.AdminUpdate(p);
            return RedirectToAction("Index");

        }
    }
}