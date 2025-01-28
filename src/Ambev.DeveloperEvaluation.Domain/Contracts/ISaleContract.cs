using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Contracts
{
    public interface ISaleContract
    {
        public Guid SaleNumber { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? BranchOfficeId { get; set; }
        public decimal TotalSaleAmount { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}