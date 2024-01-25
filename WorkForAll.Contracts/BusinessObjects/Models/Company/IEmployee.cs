namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IEmployee
public interface IEmployee : IEntity<int>, INameable
{
    /// <summary>
    /// Last name.
    /// </summary>
    string SurName { get; set; }
    /// <summary>
    /// Middle name.
    /// </summary>
    string? Patronymic { get; set; }
    string Login { get; set; }
    string Email { get; set; }
    string? PhoneNumber { get; set; }
    DateTime BirthDate { get; set; }
    int MaritalStatusId { get; set; }
    IMaritalStatus MaritalStatus { get; set; }
    ICollection<IRateRange> RateRanges { get; set; }
    ICollection<ISalary> Salaries { get; set; }
    ICollection<IScheduleEvent> ScheduleEvents { get; set; }
    ICollection<IStaff> StaffEmployees { get; set; }
    ICollection<IStaff> StaffManagers { get; set; } 
    ICollection<IWorkTimeLog> WorkTimeLogs { get; set; }
}
#endregion