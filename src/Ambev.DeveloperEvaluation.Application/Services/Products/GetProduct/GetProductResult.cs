using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Response model for GetProduct operation
/// </summary>
public class GetProductResult
{
    /// <summary>
    /// The unique identifier of the product
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The product's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The product's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// The product's phone number
    /// </summary>
    public string Phone { get; set; } = string.Empty;   

    /// <summary>
    /// The product's role in the system
    /// </summary>
    public ProductRole Role { get; set; }

    /// <summary>
    /// The current status of the product
    /// </summary>
    public ProductStatus Status { get; set; }
}
