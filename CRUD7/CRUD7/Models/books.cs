using System.ComponentModel.DataAnnotations;

namespace CRUD7.Models
{
    public class books
    {
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        public string description { get; set; }
        public int year { get; set; }
        public string isbn { get; set; }
        public int stock { get; set; }

        // Navigation property
        // Foreign Key
        public int ratingId { get; set; }
        public rating rating { get; set; }

        // Navigation property
        // Foreign Key
        public int imagesId { get; set; }
        public images images { get; set; }

        // Navigation property
        // Foreign Key
        public int genresId { get; set; }
        public genres genres { get; set; }

        // Navigation property
        // Foreign Key
        public int authorsId { get; set; }
        public authors authors { get; set; }
    }
}