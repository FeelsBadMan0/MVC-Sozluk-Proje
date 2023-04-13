using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllContent(string p)
        {
            if (p == null)
            {
                var values = cm.GetList();
                return View(values);
            }
            else
            {
                var values = cm.GetList(p);
                return View(values);
            }


        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}