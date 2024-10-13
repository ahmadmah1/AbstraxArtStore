using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using AbstraxArtStore.Areas.Identity.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstraxArtStore.Models
{
    public class Order
    {
        [Required]
        [Key] public int OrderId { get; set; } // Primary key

        [Required(ErrorMessage = "Please enter your full Name"), // This attribute will make an error message display if the user attempts to skip the field.
        MaxLength(50)] // This attribute ensures that the length of the string does not exceed 255 characters.
        [DisplayName("Full name")] // This attribute specifies the property name on the view.
        [DataType(DataType.Text)] // The type of data for this field is text.
        [RegularExpression("^([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]*)+[ ]([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]+)+$", ErrorMessage = "Please enter your full name")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents special characters such as '!','@', and numbers along with single names from being inputted into the field.
        public string FullName { get; set; }

        [Display(Name = "Order date")] // This attribute specifies the property name on the view.
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] // This attribute formats the date to be in a day/month/year form.
        public DateTime OrderDate { get; set; }
        public Order()
        {
            OrderDate = DateTime.Now; // Automatically sets the date to when the record was submitted.
        }
        // Server side C#.

        public ICollection<Payment> Payments { get; set; } // This foreign key ensures that a payment can only belong to one order (one-to-many).











    }
}

