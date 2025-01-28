using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Contracts
{
    public interface IBaseEntity
    {
        public void Activate();
        public void Deactivate();
        public void Suspend();

        public ValidationResultDetail Validate<T>(AbstractValidator<T> validator) where T : BaseEntity;
        public Task<IEnumerable<ValidationErrorDetail>> ValidateAsync();
    }
}