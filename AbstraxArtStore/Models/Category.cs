using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Category
    {
        [Required]
        [Key] public int CategoryId { get; set; }


        [Required(ErrorMessage = "Please enter a Category Name"), MaxLength(7)]
        [DisplayName("Category Name")]
        [DataType(DataType.Text)]
        [RegularExpression("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents special characters such as '!','@', and numbers from being inputted into the field.
        public string CategoryName { get; set; }


        public ICollection<Product> Products { get; set; }


    }
}
