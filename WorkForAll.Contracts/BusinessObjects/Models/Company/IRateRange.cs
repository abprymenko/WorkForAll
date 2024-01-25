namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IRateRange
public interface IRateRange : IEntity<int>
{
    decimal Min { get; set; }
    decimal Max { get; set; }
    int GradeId { get; set; }
    IGrade Grade { get; set; }
    ICollection<IPosition> Positions { get; set; }
}
#endregion