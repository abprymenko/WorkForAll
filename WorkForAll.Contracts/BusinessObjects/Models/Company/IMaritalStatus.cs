namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IMaritalStatus
public interface IMaritalStatus : IEntity<int>, ITimeStamped
{
    ICollection<IEmployee> Employees { get; set; }
}
#endregion