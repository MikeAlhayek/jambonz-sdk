namespace Jambonz.Client.V1.Models.Queues;

/// <summary>
/// Represents an active queue with a name and its current length.
/// </summary>
public sealed class ActiveQueue
{
    /// <summary>
    /// The name of the active queue.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The current number of items in the queue.
    /// </summary>
    public string Length { get; set; }
}
