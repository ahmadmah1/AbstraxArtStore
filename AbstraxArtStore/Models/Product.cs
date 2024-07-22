using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.Identity.Client;

namespace AbstraxArtStore.Models
{
    public class Product
    {
        [Required]
        [Key] public int ProductId { get; set; }

        [Required]
        public int CategoryId { get; set; } //Foreign Key


        [Required(ErrorMessage = "Please enter a product name"), MaxLength(30)]
        [DisplayName("Product name")]
        [DataType(DataType.Text)]

        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a product price"), MaxLength(30)]
        [DisplayName("Product price")]
        [DataType(DataType.Currency)]

        public string ProductPrice { get; set; }

        [Required(ErrorMessage = "Please enter a product description"), MaxLength(255)]
        [DisplayName("Product description")]
        [DataType(DataType.Text)]
        public required string ProductDesc { get; set; }

        [Required]
        public required string ProductImage { get; set; }
        

    public Category Category { get; set; }

    public ICollection<Cart> Carts { get; set; }
    }
}
