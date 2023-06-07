using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models.ProductDto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        [Required]
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
    }
}
