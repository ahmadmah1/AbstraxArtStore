using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstraxArtStore.Models
{
    public class Category
    {
        [Required]
        [Key] public int CategoryId { get; set; } // Primary key


        [Required(ErrorMessage = "Please enter a Category Name"), // This attribute will make an error message display if the user attempts to skip the field.
        MaxLength(7)] // This attribute ensures that the length of the string does not exceed 7 characters.
        [DisplayName("Category name")] // This attribute specifies the property name on the view.
        [DataType(DataType.Text)] // The type of data for this field is text.
        [RegularExpression("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$", ErrorMessage = "Please enter a valid category name")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents special characters such as '!','@', and numbers from being inputted into the field.
        public string CategoryName { get; set; }


        public ICollection<Product> Products { get; set; } // This foreign key ensures that a product can only belong to one category (one-to-many).


    }
}
