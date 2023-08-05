using System.ComponentModel.DataAnnotations.Schema;

namespace Sabutaj.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddCart { get; set; }
        [Column(TypeName ="decimal(3,0)")]
        public decimal? OldPrice { get; set; }
        [Column(TypeName = "decimal(3,0)")]
        public decimal?  NewPrice  { get; set; }
        public string DiscountRate { get; set; }
        public string ImageUrl { get; set; }

    }
}
