using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD7.Models
{
    public class images
    {
        public int Id { get; set; }
        [Required]
        public string imageUrl { get; set; }
    }
}