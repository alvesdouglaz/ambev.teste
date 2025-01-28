using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Contracts
{
    public interface ICartContract
    {
        public Guid CustumerId { get; set; }
        public Guid SaleId { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}