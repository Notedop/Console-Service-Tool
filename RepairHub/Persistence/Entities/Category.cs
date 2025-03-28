using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ConsoleServiceTool.RepairHub.Persistence.Entities
{
    public class Category : Model<long>
    {
        [MaxLength(100)] public string? Name { get; set; }

        public virtual ObservableCollectionListSource<Product> Products { get; } = new();
    }
}