using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment3_N01392504.Models
{
    public class Category
    {

        [DisplayName("Category ID")]
        public int CategoryId { get; set; }

        [DisplayName("Category")]
        public string CategoryName { get; set; }
    }
}