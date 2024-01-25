namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region ISalary
public interface ISalary : IEntity<int>
{
    decimal TotalAmount { get; set; }
    decimal Deductions { get; set; }
    decimal Bonuses { get; set; }
    /// <summary>
    /// The actual number of hours worked for the specified period.
    /// </summary>
    decimal? WorkedHours { get; set; }
    /// <summary>
    /// The number of hours that had to be worked during the specified period.
    /// </summary>
    decimal? LaborHours { get; set; }
    decimal? VacationDays { get; set; }
    decimal? SickLeaveDays { get; set; }
    decimal? BusinessTripDays { get; set; }
    decimal? PauseTime { get; set; }
    int PeriodId { get; set; }
    int EmployeeId { get; set; }
    IEmployee Employee { get; set; }
    IPeriod Period { get; set; }
}
#endregion