using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Contracts;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class BranchOffice : BaseEntity, IBranchOfficeContract
    {
        public BranchOffice() : base() { }

        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
    }
}