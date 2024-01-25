namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IActivityStatus
public interface IActivityStatus : IEntity<int>, ITimeStamped
{
    ICollection<IWorkTimeLog> WorkTimeLogs { get; set; }
}
#endregion