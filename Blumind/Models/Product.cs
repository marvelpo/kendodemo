using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blumind.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}