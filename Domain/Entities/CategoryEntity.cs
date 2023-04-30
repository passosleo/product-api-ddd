using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public string Title { get; set; }
    }
}
