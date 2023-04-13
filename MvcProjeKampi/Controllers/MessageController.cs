using BusinessLayer.Concrate;
using BusinessLayer.ValidatoinRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using System;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {

        // GET: Message
        MessageManeger mm = new MessageManeger(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();

        [Authorize]
        public ActionResult Inbox(string p)
        {
            var messageList = mm.GetListInbox(p);
            return View(messageList);
        }
        public ActionResult Sendbox(string p)
        {
            var messageList = mm.GetListSendbox(p);
            return View(messageList);
        }

        public ActionResult GetInboxMessageDetails(int id)
        {
            var Values = mm.GetByID(id);
            return View(Values);
        }

        public ActionResult GetSendboxMessageDetails(int id)
        {
            var Values = mm.GetByID(id);
            return View(Values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }


        [HttpPost]
        public ActionResult NewMessage(Message p)
        {

            ValidationResult results = messageValidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


    }
}