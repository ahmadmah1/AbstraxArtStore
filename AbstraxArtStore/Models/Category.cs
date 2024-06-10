using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "Please enter a category name"), MaxLength(30)]
        [DisplayName("Category name")]
        [DataType(DataType.Text)]

        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
