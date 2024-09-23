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
        [Key] public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your full Name"), MaxLength(50)]
        [DisplayName("Full name")]
        [DataType(DataType.Text)]
        [RegularExpression("^([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]*)+[ ]([a-zA-Z]+[\\'\\,\\.\\-]?[a-zA-Z ]+)+$", ErrorMessage = "Please enter your full name")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents special characters such as '!','@', and numbers along with single names from being inputted into the field.
        public string FullName { get; set; }

        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
        public Order()
        {
            OrderDate = DateTime.Now;
        }


        public ICollection<Payment> Payments { get; set; }











    }
}

