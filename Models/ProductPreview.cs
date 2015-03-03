using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVazar.Models
{
    public class ProductPreview
    {
        public int ProductPreviewId { get; set; }
        public string ImagePath { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
    }
}