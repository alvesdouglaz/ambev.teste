using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Contracts
{
    public interface IBranchOfficeContract
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
    }
}