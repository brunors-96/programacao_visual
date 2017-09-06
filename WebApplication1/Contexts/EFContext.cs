using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Contexts
{
    public class EFContext/*:DbContext*/ 
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Builder> Builders { get; set; }
    }
}