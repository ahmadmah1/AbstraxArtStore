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
        [DisplayName("Category Name")]
        public int CategoryId { get; set; } //Foreign Key


        [Required(ErrorMessage = "Please enter a product name"), MaxLength(30)]
        [DisplayName("Product Name")]
        [DataType(DataType.Text)]

        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a product price"), MaxLength(10)]
        [DisplayName("Product Price")]
        [DataType(DataType.Currency)]
        [RegularExpression("^[$]?[0-9]*(\\.)?[0-9]?[0-9]?$", ErrorMessage = "Please input a valid price")]

        public string ProductPrice { get; set; }

        [Required(ErrorMessage = "Please enter a product description"), MaxLength(255)]
        [DisplayName("Product Description")]
        [DataType(DataType.Text)]
        public required string ProductDesc { get; set; }

        [DisplayName("Product Image")]
        [Required(ErrorMessage = "Please enter a product image"), MaxLength(10)]
        public required string ProductImage { get; set; }
        

    public Category Category { get; set; }


    }
}
