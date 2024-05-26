using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Category
    {
        [Required]
        public int category_id { get; set; }


        [Required(ErrorMessage = "Please enter a category name"), MaxLength(30)]
        [DisplayName("Category name")]
        [DataType(DataType.Text)]

        public string category_name { get; set; }

    }
}
