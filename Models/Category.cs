using System.ComponentModel.DataAnnotations;

namespace StoreCatalogAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
