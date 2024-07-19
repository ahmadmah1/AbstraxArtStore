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

        [Required(ErrorMessage = "Please enter a category name"), MaxLength(30)]
        [DisplayName("Category name")]
        [DataType(DataType.CreditCard)]

        public string PaymentMethod { get; set; }

        [Required]
        [DataType(DataType.DateTime)]

        public string PaymentDate { get; set; }


        public ICollection<Order> Orders { get; set; }
    }
}
