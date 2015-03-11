using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace bookStore.Models
{
    public class book
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        public string description { get; set; }
        //public string genre { get; set; }
        public string isbn { get; set; }
        public int year { get; set; }
        public int stock { get; set; }

        // Foreign key
        public int authorId { get; set; }
        public int genreId { get; set; }
        // Navigation property
        public author author { get; set; }
        public genre genre { get; set; }
        
    }
}