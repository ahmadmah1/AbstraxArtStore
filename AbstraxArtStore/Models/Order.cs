using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Order
    {
        [Required]
        public int order_id { get; set; }

        [Required]
        public int customer_id { get; set; }

        [Required]
        public int payment_id { get; set; }

        [Required]
        public int cart_id { get; set; }


        [Required]
        [DataType(DataType.DateTime)]

        public string order_date { get; set; }
    }
}

