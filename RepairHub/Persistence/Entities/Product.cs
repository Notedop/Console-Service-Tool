using System.ComponentModel.DataAnnotations;

namespace ConsoleServiceTool.RepairHub.Persistence.Entities
{
    public class Product : Model<long>
    {
        public Product()
        {
        }

        [MaxLength(100)] public required string Name { get; set; }

        public long CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}