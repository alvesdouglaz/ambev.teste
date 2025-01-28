using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Contracts;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Product : BaseEntity, IProductContract
    {
        public Product() : base() {}

        public string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
    }
}