using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace bookStore.Models
{
    public class author
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}