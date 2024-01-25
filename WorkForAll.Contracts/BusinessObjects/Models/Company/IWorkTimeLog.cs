namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IWorkTimeLog
public interface IWorkTimeLog : IEntity<int>
{
    /// <summary>
    /// The time and the date when the event occurred.
    /// </summary>
    DateTime Time { get; set; }
    int EventId { get; set; }
    int ActivityStatusId { get; set; }
    int EmployeeId { get; set; }
    IActivityStatus ActivityStatus { get; set; }
    IEmployee Employee { get; set; }
    IEvent Event { get; set; }
}
#endregion