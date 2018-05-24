using System.ComponentModel.DataAnnotations;

namespace Warehouse.Models
{
    public class Product
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [UIHint("Currency")]
        [Display(Name="How much to pay")]
        [Range(1, int.MaxValue, ErrorMessage = "The price must be higher than 1 SEK")]
        public int Price { get; set; }

        [Display(Name="Amount in storage")]
        public int Quantity { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}