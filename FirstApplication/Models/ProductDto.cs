using System.ComponentModel.DataAnnotations;

namespace FirstApplication.Models
{
    public class ProductDto
    {
        [StringLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
