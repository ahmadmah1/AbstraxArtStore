using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using AbstraxArtStore.Areas.Identity.Data;

namespace AbstraxArtStore.Models
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public ApplicationUser CustomerId { get; set; }

        public int CartId { get; set; }

        public Cart Cart { get; set; }

      


        [Required]
        [DataType(DataType.DateTime)]

        public string OrderDate { get; set; }



        

    }
}

