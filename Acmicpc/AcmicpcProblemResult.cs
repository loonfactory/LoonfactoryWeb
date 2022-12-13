namespace Loonfactory.Acmicpc;

/// <summary>
/// The results of the judgment on the published solution.
/// </summary>
public enum AcmicpcProblemResult
{
    /// <summary>
    /// Awaiting judging. Wait for the judging results to be received.
    /// </summary>
    Wait,

    /// <summary>
    /// Awaiting rejudging. Wait for the rejudging results to be received.
    /// </summary>
    RejudgeWait,

    /// <summary>
    /// The rejudging program is doing a number of things to score. It includes source code compilation, execution environment setting, etc.
    /// </summary>
    Compile,

    /// <summary>
    /// Judging is in progress.
    /// </summary>
    Judging,

    /// <summary>
    /// This is the result that submitted program is correct with all the prepared data.
    /// </summary>
    Ac,

    /// <summary>
    /// The highest score obtained is not the total score for the question.
    /// </summary>
    PartialAc,

    /// <summary>
    /// This is the result where output format is different from the one shown in the question.
    /// </summary>
    FormatError,

    /// <summary>
    /// This is the result the output result is different from the correct answer
    /// </summary>
    Wa,

    /// <summary>
    /// This is the result when program does not finish within the time limit.
    /// </summary>
    TimeoutError,

    /// <summary>
    /// This is the result when program produces too much output.
    /// </summary>
    OutputOverflowError,

    /// <summary>
    /// This is the result whenprogram terminated abnormally.
    /// </summary>
    RuntimeError,
    /// <summary>
    /// This is the result when compilation fails.
    /// /// </summary>
    CompileError,

    /// <summary>
    /// This is the result when judgment is not possible.
    /// </summary>
    Co,

    /// <summary>
    /// This is the result when the submission removes it.
    /// </summary>
    Removed,
}
