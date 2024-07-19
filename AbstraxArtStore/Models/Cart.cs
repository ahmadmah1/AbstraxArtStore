using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;

namespace AbstraxArtStore.Models
{
    public class Cart
    {
        [Required]
        [Key] public int CartId { get; set; }


        [Required]
        public int ProductId { get; set; }

        [Required]
        public int OrderId { get; set; }



        [Required(ErrorMessage = "Please enter a category name")]
        [DisplayName("Category name")]
        [DataType(DataType.Text)]

        public int CartQuantity { get; set; }

        [Required(ErrorMessage = "Please enter a category name")]
        [DisplayName("Category name")]
        [DataType(DataType.Currency)]


        public Product Product { get; set; }

        public Order Order { get; set; }





    }
}
