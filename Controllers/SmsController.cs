using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace PIIT_Assignment.Controllers
{
    public class SmsController : TwilioController
    {
        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("The copy cat says: " +
                                      incomingMessage.Body);

            return TwiML(messagingResponse);
        }
    }
}