using System;
using System.Collections.Generic;

namespace Blumind.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}