using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace SurfaceBook.Models
{
    public class Administration
    {
        public int Id { get; set; }
        public string  ProductName { get; set; }
        public int Price  { get; set; }
        public string Introduction { get; set; }
        public string TheSalesAmount { get; set; }
        public string Evaluation{ get; set; }
        public int NumberOfBusinesses { get; set; }
    }
}