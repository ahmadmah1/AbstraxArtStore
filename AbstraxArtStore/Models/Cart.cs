using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Cart
    {
        [Required]
        public int cart_id { get; set; }

        [Required]
        public int customer_id { get; set; }

        [Required]
        public int product_id { get; set; }


        [Required(ErrorMessage = "Please enter a category name"), MaxLength(30)]
        [DisplayName("Category name")]
        [DataType(DataType.Text)]

        public int cart_quantity { get; set; }

        [Required(ErrorMessage = "Please enter a category name"), MaxLength(30)]
        [DisplayName("Category name")]
        [DataType(DataType.Currency)]

        public int total_price { get; set; }

        public ICollection<Product> Products { get; set; }
        public Order Order { get; set; }



    }
}
