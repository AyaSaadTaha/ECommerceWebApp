using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ECommerceWebApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(18, 100)]
        public long Age { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        public virtual  List<Order> ? OrderList { get; set; }


    }
}
