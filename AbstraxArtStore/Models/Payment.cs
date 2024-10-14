using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstraxArtStore.Models
{
    public enum PaymentM // This defines the values that will be from the options a user can select. It defines the name PaymentM (below), which creates the options.
    {
        [Display(Name = "Credit")]
        Credit,
        [Display(Name = "Cash")]
        Cash,
        [Display(Name = "Bank Transfer")]
        BankTransfer

    }
    public class Payment
    {
        [Required]
        [Key] public int PaymentId { get; set; } // Primary key

        [Required]
        [DisplayName("Order Name")]
        public int OrderId { get; set; }


        // This [Column(TypeName = "decimal(7,2)")] defines the decimal field for the price.
        // The '7' refers to the total amount of digits allowed and the '2' refers to the total amount of digits allowed after the decimal point.
        [Required(ErrorMessage = "Please enter a payment amount")]
        [Column(TypeName = "decimal(7,2)")]
        [Range(0.01, 9999.99, ErrorMessage = "Price must be between $0.01 and $999.99")]
        [Display(Name = "Order total")]
        [RegularExpression("^[$]?[0-9]*(\\.)?[0-9]?[0-9]?$", ErrorMessage = "Please input a valid payment amount")]


        public required decimal PaymentAmount { get; set; }


        [Required(ErrorMessage = "Please enter your payment method")]
        [DisplayName("Payment Method")]


        public PaymentM PaymentMethod { get; set; }

        [Display(Name = "Payment Date")] // This attribute specifies the property name on the view.
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] // This attribute formats the date to be in a day/month/year form.
        public DateTime PaymentDate { get; set; }
        public Payment()
        {
            PaymentDate = DateTime.Now; // Automatically sets the date to when the record was submitted.
        }
        // Server side C#.

        public Order order { get; set; } // This foreign key ensures that an order can have many payments with the same information (one-to-many).





    }
}
