using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication6.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Product")]
        public string Product_Categ {  get; set; }
    }
}
