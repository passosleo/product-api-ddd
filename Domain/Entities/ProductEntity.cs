using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public string? Image { get; set; }

        public decimal Price { get; set; }
    }
}
