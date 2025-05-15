namespace Jambonz.Client.V1.Models.Users;

/// <summary>
/// Represents a product associated with the current user.
/// </summary>
public sealed class CurrentProduct
{
    /// <summary>
    /// Name of the product.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Product description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Product category.
    /// </summary>
    public string Category { get; set; }

    /// <summary>
    /// Quantity (as string) available or included.
    /// </summary>
    public string Quantity { get; set; }

    /// <summary>
    /// Indicates if the product is included in a starter set.
    /// </summary>
    public bool InStarterSet { get; set; }

    /// <summary>
    /// Unique identifier for the product.
    /// </summary>
    public string ProductSid { get; set; }

    /// <summary>
    /// Start date of product effectiveness.
    /// </summary>
    public DateTime EffectiveStartDate { get; set; }

    /// <summary>
    /// End date of product effectiveness.
    /// </summary>
    public DateTime EffectiveEndDate { get; set; }
}
