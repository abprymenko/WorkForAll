namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IStaff
public interface IStaff : IEntity<int>
{
    int DepartmentId { get; set; }
    int PositionId { get; set; }
    int? EmployeeId { get; set; }
    int? EmploymentTypeId { get; set; }
    decimal? Rate { get; set; }
    DateTime? HireDate { get; set; }
    DateTime? TerminationDate { get; set; }
    bool? IsBlocked { get; set; }
    int? ManagerId { get; set; }
    IDepartment Department { get; set; }
    IEmployee? Employee { get; set; }
    IEmploymentType? EmploymentType { get; set; }
    IEmployee? Manager { get; set; }
    IPosition Position { get; set; }
}
#endregion