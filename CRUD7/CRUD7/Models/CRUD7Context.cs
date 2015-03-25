using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD7.Models
{
    public class CRUD7Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CRUD7Context() : base("name=CRUD7Context")
        {
        }

        public System.Data.Entity.DbSet<CRUD7.Models.books> books { get; set; }

        public System.Data.Entity.DbSet<CRUD7.Models.authors> authors { get; set; }

        public System.Data.Entity.DbSet<CRUD7.Models.genres> genres { get; set; }

        public System.Data.Entity.DbSet<CRUD7.Models.images> images { get; set; }

        public System.Data.Entity.DbSet<CRUD7.Models.rating> ratings { get; set; }
    
    }
}
