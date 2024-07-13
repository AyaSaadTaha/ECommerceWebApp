using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Descrption { get; set; }
        [Required]
        [Range(100, 2000)]
        public double Price { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public virtual ProductType? ProductType { get; set; }


        public virtual  List<Order>? OrderList { get; set; }

    }
}
