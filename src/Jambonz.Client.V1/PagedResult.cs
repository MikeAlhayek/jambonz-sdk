namespace Jambonz.Client.V1;

public abstract class PagedResult<T>
{
    /// <summary>
    /// The total number of records available.
    /// </summary>
    public int Total { get; set; }

    /// <summary>
    /// The current batch number.
    /// </summary>
    public int Batch { get; set; }

    /// <summary>
    /// The current page number.
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// The list of the entries.
    /// </summary>
    public IEnumerable<T> Data { get; set; }
}
