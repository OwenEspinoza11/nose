using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models.ProductDto
{
    public class UpdateProductDto
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(40)]
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
    }
}
