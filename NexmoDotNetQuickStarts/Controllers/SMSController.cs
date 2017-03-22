using Nexmo.Api;
using System.Web.Mvc;
using System.Diagnostics;
using System.Web.Http;
using Newtonsoft.Json;
using System.IO;

namespace NexmoDotNetQuickStarts.Controllers
{
    // For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
    
        public class SMSController : Controller
        {

            public ActionResult Index()
            {
                return View();
            }

            [System.Web.Mvc.HttpGet]
            public ActionResult Send()
            {
                return View();
            }
            
            [System.Web.Mvc.HttpPost]
            public ActionResult Send(string to, string text)
            {

                var results = SMS.Send(new SMS.SMSRequest
                {

                    from = Configuration.Instance.Settings["appsettings:NEXMO_FROM_NUMBER"],
                    to = to,
                    text = text
                });
                return View("Index");
            }
    }

}
