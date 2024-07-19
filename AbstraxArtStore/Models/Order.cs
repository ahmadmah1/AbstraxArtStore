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

        [Required]
        public ApplicationUser CustomerId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]

        public string OrderDate { get; set; }




        public ICollection<Cart> Carts { get; set; }

        public Payment Payment { get; set; }







    }
}

