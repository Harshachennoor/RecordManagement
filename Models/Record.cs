using System;
using System.ComponentModel.DataAnnotations;

namespace RecordsManagement.Models
{
    public class Record
    {
        public int RecordId { get; set; }

        [Required(ErrorMessage = "Enter product name")]
        [RegularExpression("^[a-zA-Z0-9'\\s.-]+$",ErrorMessage ="Must be characters,digits and '")]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Enter product code")]
        [RegularExpression("^[a-zA-Z0-9]+$",ErrorMessage ="Must be characters and digits")]
        //[UniqueCode]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please select a Category")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Enter the description")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Between 4 to 200 Charaters only")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter the price")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Numeric with two decimal places only")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Please select the Warehouse")]
        public string WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        [Required(ErrorMessage ="Enter Vendor details")]
        [RegularExpression("^[a-zA-Z0-9'\\s]+$",ErrorMessage ="Must be characters,digits and '")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Between 5 to 50 Charaters only")]
        public string Vendor { get; set; }

        [Required(ErrorMessage ="Enter the Quantity")]
        [Range(0, 100, ErrorMessage = "0 to 100")]
        public int Quantity { get; set; }

    }
}