namespace WorkForAll.Contracts.BusinessObjects.Models;

#region Usings
using WorkForAll.Contracts.BusinessObjects.Models.Company;
#endregion

#region INameable
public interface INameable
{
    /// <summary>
    /// Name of <see cref="IDepartment"/>, <see cref="IPosition"/>  or first (given) name of <see cref="IEmployee"/>, etc.
    /// </summary>
    string Name { get; set; }
}
#endregion