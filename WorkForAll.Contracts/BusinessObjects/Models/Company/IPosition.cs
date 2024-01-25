namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IPosition
public interface IPosition : IEntity<int>, IDescribable, INameable
{
    int RateRangeId { get; set; }
    IRateRange RateRange { get; set; }
    ICollection<IStaff> Staff { get; set; }
}
#endregion