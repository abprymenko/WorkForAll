namespace WorkForAll.Contracts.BusinessObjects.Models.Company;

#region IDepartment
public interface IDepartment : IEntity<int>, IDescribable, INameable
{
    /// <summary>
    /// 0 - is being disbanded, 1- is active, null - has been disbanded
    /// </summary>
    public bool? IsActive { get; set; }
    public int? ParentId { get; set; }
    ICollection<IDepartment> InverseParent { get; set; }
    IDepartment? Parent { get; set; }
    ICollection<IStaff> Staff { get; set; }
}
#endregion