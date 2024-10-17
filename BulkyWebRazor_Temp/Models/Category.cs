using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor_Temp.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Id ")]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name ")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 30, ErrorMessage = "Here is an Error. Please check...")]
        public string DisplayOrder { get; set; }
    }
}
