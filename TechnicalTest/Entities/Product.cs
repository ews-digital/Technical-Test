using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalTest.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "Money")]
        public decimal Price { get; set; }
    }
}
