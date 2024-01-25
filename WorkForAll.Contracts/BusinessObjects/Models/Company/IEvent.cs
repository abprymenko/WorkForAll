namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IEvent
public interface IEvent : IEntity<int>, ITimeStamped
{
    ICollection<IScheduleEvent> ScheduleEvents { get; set; }
    ICollection<IWorkTimeLog> WorkTimeLogs { get; set; }
}
#endregion