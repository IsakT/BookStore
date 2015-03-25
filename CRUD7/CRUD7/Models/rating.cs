using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD7.Models
{
    public class rating
    {
        public int Id { get; set; }
        [Required]
        public double rate { get; set; }
    }
}