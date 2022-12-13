namespace Loonfactory.Acmicpc;

/// <summary>
/// Represents that publish a solution to a problem on Acmicpc.
/// </summary>
public class AcmicpcProblemPublish
{
    /// <summary>
    /// Publish number given when submitted a solution.
    /// </summary>
    public int? PublishNo { get; set; }

    /// <summary>
    /// Problem id on Acmicpc.
    /// </summary>
    public string? ProblemId { get; set; }

    /// <summary>
    /// User id that submitted the solution.
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// The judging result of the solution.
    /// </summary>
    public AcmicpcProblemResult? Result { get; set; }

    /// <summary>
    /// The date the solution was published.
    /// </summary>
    public DateTime? PublishAt { get; set; }

    /// <summary>
    /// A random value that should change whenever publish state is persisted to the store.
    /// </summary>
    public string? ConcurrencyStamp { get; set; }
}
