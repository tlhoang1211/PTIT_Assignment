using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIIT_Assignment.Models
{
    public class UserAccount
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public int status { get; set; } // 1 - Active / 0 - Deactive
        public string secret_code { get; set; }
    }
}