using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD7.Models
{
    public class authors
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
    }
}