using System.ComponentModel.DataAnnotations;

namespace BookManagementApi.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }  
        public int YearPublished { get; set; }
    }
}
