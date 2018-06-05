using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WagenPark.Classes;

namespace WagenPark.Models
{
    public class WagenParkContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WagenParkContext() : base("WagenParkContext")
        {

        }
            public DbSet<Auto> Autos { get; set; }
            public DbSet<Dealer> Dealer { get; set; }
            public DbSet<Onderhoud> Onderhoud { get; set; }
            public DbSet<Werkplaats> Werkplaatsen { get; set; }

        public System.Data.Entity.DbSet<WagenPark.Classes.Auto> Autoes { get; set; }

        public System.Data.Entity.DbSet<WagenPark.Classes.Dealer> Dealers { get; set; }
    }
}
