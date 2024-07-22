using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AbstraxArtStore.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstraxArtStore.Models
{
    public class Cart
    {
        [Required]
        [Key] public int CartId { get; set; }


        [Required]
        [ForeignKey("Order")] public int? Order_Id { get; set; } // Foreign Key

        [Required]
        public int OrderId { get; set; }



        [Required(ErrorMessage = "Please enter a category name")]
        [DisplayName("Category name")]
        [DataType(DataType.Text)]

        public int CartQuantity { get; set; }

        [Required(ErrorMessage = "Please enter the amount of products")]
        [DisplayName("Quantity")]
         public int quantity { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }

        

    }
    }


    