using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Contracts;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Cart : BaseEntity, ICartContract
    {
        public Guid CustumerId { get; set; }
        public Guid SaleId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public Cart() : base() {}
    }
}