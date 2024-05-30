using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Product
    {
        [Required]
        public int product_id { get; set; }

        [Required]
        public int category_id { get; set; }


        [Required(ErrorMessage = "Please enter a product name"), MaxLength(30)]
        [DisplayName("Product name")]
        [DataType(DataType.Text)]

        public string product_name { get; set; }

        [Required(ErrorMessage = "Please enter a product price"), MaxLength(30)]
        [DisplayName("Product price")]
        [DataType(DataType.Currency)]

        public int product_price { get; set; }

        [Required(ErrorMessage = "Please enter a product description"), MaxLength(255)]
        [DisplayName("Product description")]
        [DataType(DataType.Text)]

        public string product_desc { get; set; }

        [Required(ErrorMessage = "Please enter a product image"), MaxLength(255)]
        [DisplayName("Product image")]
        [DataType(DataType.Upload)]

        public string product_image { get; set; }

        public Category Category { get; set; }

        public Cart Cart { get; set; }


    }
}
