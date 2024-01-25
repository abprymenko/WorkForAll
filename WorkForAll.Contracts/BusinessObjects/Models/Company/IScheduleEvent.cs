namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IScheduleEvent
public interface IScheduleEvent : IEntity<int>
{
    /// <summary>
    /// 0 - is waiting, 1 - being used, null - has used
    /// </summary>
    bool? IsUsed { get; set; }
    int EventId { get; set; }
    int PeriodId { get; set; }
    int EmployeeId { get; set; }
    IEmployee Employee { get; set; }
    IEvent Event { get; set; }
    IPeriod Period { get; set; }
}
#endregion