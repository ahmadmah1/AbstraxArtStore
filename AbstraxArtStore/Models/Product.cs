using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstraxArtStore.Models
{
    public class Product
    {
        [Required]
        
        [Key] public int ProductId { get; set; } // Primary Key

        [Required] // Specifies that the field is mandatory and cannot be skipped.
        [DisplayName("Category Name")] // This attribute specifies the property name on the view.
        public int CategoryId { get; set; } // Foreign Key


        [Required(ErrorMessage = "Please enter a product name"), // This attribute will make an error message display if the user attempts to skip the field.
        MaxLength(30)] // This attribute ensures that the length of the string does not exceed 30 characters.
        [DisplayName("Product Name")] // This attribute specifies the property name on the view.
        [DataType(DataType.Text)] // The type of data for this field is text.

        public string ProductName { get; set; }
        
        [Column(TypeName ="nvarchar(100)")] // The file name for the image cannot exceed 100 characters.
        [DisplayName("Product Image")]
        public string ImageName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Product Image")]
        [Required(ErrorMessage = "Please enter a product image")]
        [NotMapped]
        public IFormFile ProductImage { get; set; } // IFormFile allows for the image functionality to work.



        // This [Column(TypeName = "decimal(7,2)")] defines the decimal field for the price.
        // The '7' refers to the total amount of digits allowed and the '2' refers to the total amount of digits allowed after the decimal point.
        
        [Required(ErrorMessage = "Please enter a product price")]
        [Column(TypeName = "decimal(7,2)")]
        [Range(0.01, 9999.99, ErrorMessage = "Price must be between $0.01 and $999.99")]
        [Display(Name = "Product Price")]
        [RegularExpression("^[$]?[0-9]*(\\.)?[0-9]?[0-9]?$", ErrorMessage = "Please input a valid price")]


        public required decimal ProductPrice { get; set; } // decimal datatype which will allow for prices to be inputted.

        [Required(ErrorMessage = "Please enter a product description with a maximum of 255 characters"), MaxLength(255)] // This attribute ensures that the length of the string does not exceed 255 characters.
        [DisplayName("Product Description")]
        [DataType(DataType.Text)]
        public required string ProductDesc { get; set; }


        

    public Category Category { get; set; } // This foreign key ensures that a category can belong to many products (one-to-many).


    }
}
