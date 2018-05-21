using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using Sitek.Attributes;
using Sitek.Controllers;
using SITEK.Models;

namespace SITEK.Controllers
{
    [Localization("en")]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Engineering()
        {
            return View();
        }
        public ActionResult Procurement()
        {
            return View();
        }
        public ActionResult Construction()
        {
            return View();
        }
        public ActionResult Maintenance()
        {
            return View();
        }
        public ActionResult MechCompletion()
        {
            return View();
        }
        public ActionResult Training()
        {
            return View();
        }
        public ActionResult Hseq()
        {
            return View();
        }
        public ActionResult Career()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult SearchResult()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendMessage(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("info@sitekcaspian.com"));  // replace with valid value 
                message.Subject = "Обращение с сайта";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Contact", "Home");
                }
            }
            return RedirectToAction("Contact", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCv(CvFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("cv@sitekcaspian.com"));  // replace with valid value 
                message.Subject = "Новый кандидат";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                if (model.Upload != null && model.Upload.ContentLength > 0)
                {
                    message.Attachments.Add(new Attachment(model.Upload.InputStream, Path.GetFileName(model.Upload.FileName)));
                }
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Career", "Home");
                }
            }
            return RedirectToAction("Career", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Subscribe(SubcscribeModel model)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("info@sitekcaspian.kz"));  // replace with valid value 
            message.Subject = "Обращение с сайта";
            message.Body = string.Format(body, "новый подписчик" , model.FromEmail, "Добавьте меня, пожалуйста, к списку подписчиков");
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);
                return RedirectToAction("Contact", "Home");
            }
        }
    }
}