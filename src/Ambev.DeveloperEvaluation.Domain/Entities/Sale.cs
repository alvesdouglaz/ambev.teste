using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale
    {
        public Sale()
        {
            Id = new Guid();
        }

        public Guid Id { get; init; }
        public Guid SaleNumber { get; set; }
        public IEnumerable<Product>? Products { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}