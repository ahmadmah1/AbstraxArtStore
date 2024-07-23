using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstraxArtStore.Models
{
    public class Payment
    {
        [Required]
        [Key] public int PaymentId { get; set; }

        [Required]
        [DisplayName("Order Name")]
        public int OrderId { get; set; }


        // This [Column(TypeName = "decimal(7,2)")] defines the decimal field for the price.
        // The '7' refers to the total amount of digits allowed and the '2' refers to the total amount of digits allowed after the decimal point.
        // This [Column(TypeName = "decimal(7,2)")] defines the decimal field for the price.
        // The '7' refers to the total amount of digits allowed and the '2' refers to the total amount of digits allowed after the decimal point.
        [Required(ErrorMessage = "Please enter a product price")]
        [Column(TypeName = "decimal(7,2)")]
        [Display(Name = "Product Price")]
        [RegularExpression("^[$]?[0-9]*(\\.)?[0-9]?[0-9]?$", ErrorMessage = "Please input a valid price")]


        public required decimal PaymentAmount { get; set; }


        [Required(ErrorMessage = "Please enter your payment method"), MaxLength(15)]
        [DisplayName("Payment Method")]
        [DataType(DataType.Text)]

        public string PaymentMethod { get; set; }

        [Display(Name = "Payment Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }
        public Payment()
        {
            PaymentDate = DateTime.Now;
        }

        public Order order { get; set; }





    }
}
