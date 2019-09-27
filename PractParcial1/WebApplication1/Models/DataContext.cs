using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Contact> Contacts { get; set; }
    }
}