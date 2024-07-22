using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using AbstraxArtStore.Areas.Identity.Data;

namespace AbstraxArtStore.Models
{
    public class Order
    {
        [Required]
        [Key] public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your full name"), MaxLength(30)]
        [DisplayName("Full name")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
        public Order()
        {
            OrderDate = DateTime.Now;
        }


        public ICollection<Payment> Payments { get; set; }










    }
}

