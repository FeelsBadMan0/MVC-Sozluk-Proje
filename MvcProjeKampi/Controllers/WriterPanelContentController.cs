using BusinessLayer.Concrate;
using DataAccesLayer.Concrate;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        Context c = new Context();
        public ActionResult MyContent(string p)
        {
            p = (string)Session["WriterMail"];
            var writerIdInfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
            var contentvalues = cm.GetListByWriter(writerIdInfo);
            return View(contentvalues);
        }

        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
            var writerIdInfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();
            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = writerIdInfo;
            p.ContentStatus = true;
            cm.ContentAdd(p);

            return RedirectToAction("MyContent");
        }

        public ActionResult ToDoList()
        {
            return View();

        }
    }
}