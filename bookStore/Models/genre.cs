using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bookStore.Models
{
    public class genre
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
    }
}