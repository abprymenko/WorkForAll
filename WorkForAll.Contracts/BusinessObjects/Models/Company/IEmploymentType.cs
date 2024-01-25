namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IEmploymentType
public interface IEmploymentType : IEntity<int>, ITimeStamped
{
    ICollection<IStaff> Staff { get; set; }
}
#endregion