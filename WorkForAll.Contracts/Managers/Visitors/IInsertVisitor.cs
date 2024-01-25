namespace WorkForAll.Contracts.Managers.Visitors;


#region Usings
using WorkForAll.Contracts.BusinessObjects.Models.Company;
using Dapper;
#endregion

#region IInsertVisitor
public interface IInsertVisitor
{
    DynamicParameters Visit(IActivityStatus activityStatus); 
    DynamicParameters Visit(IDepartment department); 
    DynamicParameters Visit(IEmployee employee); 
    DynamicParameters Visit(IEmploymentType employmentType); 
    DynamicParameters Visit(IEvent eventType); 
    DynamicParameters Visit(IGrade grade); 
    DynamicParameters Visit(IMaritalStatus maritalStatus); 
    DynamicParameters Visit(IPeriod period); 
    DynamicParameters Visit(IPosition position); 
    DynamicParameters Visit(IRateRange rateRange); 
    DynamicParameters Visit(ISalary salary); 
    DynamicParameters Visit(IScheduleEvent scheduleEvent); 
    DynamicParameters Visit(IStaff staff); 
    DynamicParameters Visit(IWorkTimeLog workTimeLog); 
}
#endregion