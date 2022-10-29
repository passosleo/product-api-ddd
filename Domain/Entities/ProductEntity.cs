using System.Reflection.Metadata;

namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid Category { get; set; }

        public string? Image { get; set; }

        public decimal Price { get; set; }
    }
}
