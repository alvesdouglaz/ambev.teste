using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Contracts;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Customer : BaseEntity, ICustomerContract
    {
        #region Atributes
        public string? Name { get; set; }
        #endregion Atributes

        #region Methods
        public Customer() : base() { }
        #endregion Methods
    }
}