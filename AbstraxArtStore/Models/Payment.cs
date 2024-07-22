using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstraxArtStore.Models
{
    public class Payment
    {
        [Required]
        [Key] public int PaymentId { get; set; }

        [Required]
        [DisplayName("Order Name")]
        public int OrderId { get; set; }



        [Required(ErrorMessage = "Please enter the payment amount"), MaxLength(10)]
        [DisplayName("Payment Amount")]
        [DataType(DataType.Text)]
        [RegularExpression("^[$]?[0-9]*(\\.)?[0-9]?[0-9]?$", ErrorMessage = "Please input a valid payment amount")]
        public string PaymentAmount { get; set; }

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
