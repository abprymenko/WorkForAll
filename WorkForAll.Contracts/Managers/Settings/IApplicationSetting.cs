namespace WorkForAll.Contracts.Managers.Settings;


#region IApplicationSetting
public interface IApplicationSetting
{
    string? MsSqlConnectionString { get; }
}
#endregion