namespace CashierApp.DataAccessor;

public interface IApiDataReader
{
    Task<string> Read(string baseAddress, string requestUri);
}
