using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Contracts;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Common;

public class BaseEntity : IComparable<BaseEntity>, IBaseEntity
{
    public Guid Id { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public GeneralStatus Status { get; set; }

    public BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        Status = GeneralStatus.Unknown;
    }

    public int CompareTo(BaseEntity? other)
    {
        if (other == null) return 1;

        return other!.Id.CompareTo(Id);
    }

    public ValidationResultDetail Validate<T>(AbstractValidator<T> validator) where T : BaseEntity
    {
        var result = validator.Validate((T) this); // Cast para o tipo derivado
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
    
    public Task<IEnumerable<ValidationErrorDetail>> ValidateAsync()
    {
        return Validator.ValidateAsync(this);
    }

    public void Activate()
    {
        Status = GeneralStatus.Active;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deactivate()
    {
        Status = GeneralStatus.Inactive;
        DeletedAt = DateTime.UtcNow;
    }

    public void Suspend()
    {
        Status = GeneralStatus.Suspended;
        UpdatedAt = DateTime.UtcNow;
    }
}
