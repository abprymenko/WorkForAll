namespace WorkForAll.Contracts.Services.Configurations;

#region Usings
using Microsoft.Extensions.Configuration;
#endregion

#region IJsonConfiguration
public interface IJsonConfiguration
{
    IConfiguration? Configuration { get; }
    string? GetString(string name);
    int? GetInt(string key);
    long? GetLong(string key);
}
#endregion