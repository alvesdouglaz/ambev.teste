using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Contracts;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity, ISaleContract
    {
        public Sale() : base() { }

        public Guid SaleNumber { get; set; }
        public Guid? BranchOfficeId { get; set; }
        public Guid? CustomerId { get; set; }
        public IEnumerable<Product>? Products { get; set; }
        public decimal TotalSaleAmount { get; set; } = 0;
    }
}