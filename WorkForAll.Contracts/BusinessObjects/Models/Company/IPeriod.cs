namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IPeriod
public interface IPeriod : IEntity<int>, IDescribable
{
    DateTime Start { get; set; }
    DateTime End { get; set; }
    ICollection<ISalary> Salaries { get; set; }
    ICollection<IScheduleEvent> ScheduleEvents { get; set; }
}
#endregion