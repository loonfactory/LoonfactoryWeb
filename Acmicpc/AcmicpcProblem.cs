namespace Loonfactory.Acmicpc;

/// <summary>
/// Represents an problem posted on Acmicpc.
/// </summary>
public class AcmicpcProblem
{
    /// <summary>
    /// Problem id on Acmicpc.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Title of the problem.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Normalized title of the problem.
    /// </summary>
    public string? NormalizedTitle { get; set; }
}
