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
        [DisplayName("Order Id")]
        [ForeignKey("Order")] public int? Order_Id { get; set; } //Foreign Key

     



        [Required(ErrorMessage = "Please enter your full name"), MaxLength(25)]
        [DisplayName("Full Name")]
        [DataType(DataType.Text)]
        [RegularExpression("^([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]*)+[ ]([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]+)+$", ErrorMessage = "Please enter your full name")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents special characters such as '!','@' and numbers along with single names from being inputted into the field.
        public string FullName { get; set; }



        [Required(ErrorMessage = "Please enter the amount of products"), Range(1, 100)]
        [DisplayName("quantity")]
        public int quantity { get; set; }


        public Order Order { get; set; }

        

    }
    }


    