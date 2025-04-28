using System.ComponentModel.DataAnnotations;

namespace ProductCategoryManagement1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; }
    }
}
