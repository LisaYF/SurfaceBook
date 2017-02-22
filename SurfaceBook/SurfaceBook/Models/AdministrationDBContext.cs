using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using SurfaceBook.Models;


namespace SurfaceBook.Models
{
   
        public class AdministrationDBContext : DbContext
        {
            public AdministrationDBContext()
                : base("SurfaceBook")
            { }
            public DbSet<Administration> Administrator { get; set; }
        }
  
}