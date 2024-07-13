using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerceWebApp.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Type")]
        public string Type { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        public virtual List<Product>? ProductsList { get; set; }
    }
}
