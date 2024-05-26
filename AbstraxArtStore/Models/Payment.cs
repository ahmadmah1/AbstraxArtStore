using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Payment
    {
        [Required]
        public int payment_id { get; set; }

        [Required]
        public int customer_id { get; set; }



        [Required]
        [DataType(DataType.Text)]

        public int payment_amount { get; set; }

        [Required(ErrorMessage = "Please enter a category name"), MaxLength(30)]
        [DisplayName("Category name")]
        [DataType(DataType.CreditCard)]

        public string payment_method { get; set; }

        [Required]
        [DataType(DataType.DateTime)]

        public string payment_date { get; set; }
    }
}
