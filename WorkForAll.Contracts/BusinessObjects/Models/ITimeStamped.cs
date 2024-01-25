namespace WorkForAll.Contracts.BusinessObjects.Models;

#region Usings
using WorkForAll.Constants.Enums;
#endregion

#region ITimeStamped
public interface ITimeStamped
{
    /// <summary>
    /// The date and the time when the code was created.
    /// </summary>
    DateTime CreatedOn { get; set; }
    /// <summary>
    /// The date and the time when the code was modified.
    /// </summary>
    DateTime? ModifiedOn { get; set; }
    /// <summary>
    /// <see cref="ActivityStatus"/>
    /// <see cref="MaritalStatus"/>
    /// <see cref="EventType"/>
    /// <see cref="Grade"/>
    /// <see cref="EmploymentType"/>
    /// </summary>
    int Code { get; set; }
}
#endregion