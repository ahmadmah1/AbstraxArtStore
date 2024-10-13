using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstraxArtStore.Models
{
    public class Cart
    {
        [Required]
        [Key] public int CartId { get; set; } // Primary key


        [Required]
        [DisplayName("Order Name")]
        [ForeignKey("Order")] public int? Order_Id { get; set; } //Foreign Key

     



        [Required(ErrorMessage = "Please enter your preferred name for the order"), // This attribute will make an error message display if the user attempts to skip the field.
        MaxLength(25)] // This attribute ensures that the length of the string does not exceed 25 characters.
        [DisplayName("Preferred order name")] // This attribute specifies the property name on the view.
        [DataType(DataType.Text)] // The type of data for this field is text.

        public string FullName { get; set; }



        [Required(ErrorMessage = "Please enter the amount of products"), Range(1, 100)] // This attribute sets a range between two numbers.
        [DisplayName("quantity")]
        public int quantity { get; set; }


        public Order Order { get; set; } // This foreign key ensures that an order can have many carts with the same information (one-to-many).



    }
    }


    