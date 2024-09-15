using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstraxArtStore.Models
{
    public class Cart
    {
        [Required]
        [Key] public int CartId { get; set; }


        [Required]
        [DisplayName("Order in the name of...")]
        [ForeignKey("Order")] public int? Order_Id { get; set; } //Foreign Key

     



        [Required(ErrorMessage = "Please enter your Full Name"), MaxLength(50)]
        [DisplayName("Full Name")]
        [DataType(DataType.Text)]
        [RegularExpression("^([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]*)+[ ]([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]+)+$", ErrorMessage = "Please enter your full name")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents special characters such as '!','@', and numbers from being inputted into the field.
        public string FullName { get; set; }



        [Required(ErrorMessage = "Please enter the amount of products")]
        [DisplayName("Quantity")]
        [Range(1, 99999, ErrorMessage = "Number is not valid")]
        public int quantity { get; set; }


        public Order Order { get; set; }

        

    }
    }


    