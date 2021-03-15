using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PIIT_Assignment.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name = SMSProjectConnectionString")
        {

        }
        public virtual DbSet<UserAccount> Users { get; set; }
    }
}