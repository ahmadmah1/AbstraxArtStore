using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;

namespace AbstraxArtStore.Models
{
    public class Payment
    {
        [Required]
        [Key] public int PaymentId { get; set; }

        public int OrderId { get; set; }



        [Required]
        [DataType(DataType.Text)]

        public int PaymentAmount { get; set; }

        [Required(ErrorMessage = "Please enter your payment method"), MaxLength(30)]
        [DisplayName("Payment Method")]
        [DataType(DataType.Text)]

        public string PaymentMethod { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }
        public Payment()
        {
            PaymentDate = DateTime.Now;
        }


        public Order order { get; set; }





    }
}
