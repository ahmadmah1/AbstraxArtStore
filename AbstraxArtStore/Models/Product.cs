using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        [Column(TypeName ="nvarchar(255)")]
        [DisplayName("Product Image")]
        public string ImageName { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [DisplayName("Product Image")]
        [Required(ErrorMessage = "Please enter a product image")]
        [NotMapped]
        public IFormFile ProductImage { get; set; }



        // This [Column(TypeName = "decimal(7,2)")] defines the decimal field for the price.
        // The '7' refers to the total amount of digits allowed and the '2' refers to the total amount of digits allowed after the decimal point.
        [Required(ErrorMessage = "Please enter a product price")]
        [Column(TypeName = "decimal(7,2)")]
        [Display(Name = "Product Price")]
        [RegularExpression("^[$]?[0-9]*(\\.)?[0-9]?[0-9]?$", ErrorMessage = "Please input a valid price")]

        public required decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "Please enter a product description"), MaxLength(255)]
        [DisplayName("Product Description")]
        [DataType(DataType.Text)]
        public required string ProductDesc { get; set; }


        

    public Category Category { get; set; }


    }
}
