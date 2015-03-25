using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD7.Models
{
    public class genres
    {
        public int Id { get; set; }
        [Required]
        public string genre { get; set; }
        public string description { get; set; }
    }
}