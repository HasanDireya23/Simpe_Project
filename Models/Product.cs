using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = ("Max Number Of character is 500"))]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Is Required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price Is Required")]
        [Range(100, maximum: 1000, ErrorMessage = ("Price Must Be Between 100-1000"))]
        public double Price { get; set; }

        [Required(ErrorMessage = "Quantity Is Required")]
        public int Quantity { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email Is Required")]
        public string Company_Email { get; set; }

        public string Category { get; set; }

        //[Phone]
        //public string Phone_Number { get; set; }
        //[RegularExpression("^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$\r\n")]
        // public string SerialNumer { get; set; }
    }
}