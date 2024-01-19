using System.ComponentModel.DataAnnotations;

namespace RecordsManagement.Models
{
    public class Category
    {
        [Required]
        public string CategoryId { get; set; }

        public string Name { get; set; }
    }
}