namespace WorkForAll.Contracts.BusinessObjects.Models;

#region IEntity
public interface IEntity<out T> : IInsertAcceptor
{
    T Id { get; }
}
#endregion