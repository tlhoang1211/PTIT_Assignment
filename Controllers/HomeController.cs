using PIIT_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace PIIT_Assignment.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Index(UserAccount account)
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            string accountSid = Environment.GetEnvironmentVariable("ACec895e2ae35eacb518864ce748c776ab");
            string authToken = Environment.GetEnvironmentVariable("130dfa6d492eb87cc6763523574e810a");

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Your OTP Code to verify new accout is: " + r,
                from: new Twilio.Types.PhoneNumber("+15017122661"),
                to: new Twilio.Types.PhoneNumber(account.phoneNumber)
            );

            Console.WriteLine(message.Sid);
            return RedirectToAction("Validate");
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