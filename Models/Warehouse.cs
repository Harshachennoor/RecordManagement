using System.ComponentModel.DataAnnotations;

namespace RecordsManagement.Models{
    public class Warehouse{
        [Required]
        public string WarehouseId { get; set; }

        public string Name { get; set; }
        }
}