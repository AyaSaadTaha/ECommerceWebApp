using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ECommerceWebApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public double Price { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
