namespace WorkForAll.Contracts.BusinessObjects.Models;

#region Usings
using WorkForAll.Contracts.Managers.Visitors;
using Dapper;
#endregion

#region IInsertAcceptor
public interface IInsertAcceptor
{
    DynamicParameters AcceptInsert(IInsertVisitor visitor);
}
#endregion