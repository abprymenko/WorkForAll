namespace WorkForAll.Constants.Enums;

#region ActivityStatus
public enum ActivityStatus
{
    /// <summary>
    /// The end of the working day.
    /// </summary>
    //'A' -> 65 * 10(decimal) + 'S' -> 69
    End = 719,
    /// <summary>
    /// A short period when someone an activity is stopped.
    /// </summary>
    Pause = 730,
    /// <summary>
    /// Starting an activity again.
    /// </summary>
    Resume = 732,
    /// <summary>
    /// The start of the working day.
    /// </summary>
    Start = 733
}
#endregion