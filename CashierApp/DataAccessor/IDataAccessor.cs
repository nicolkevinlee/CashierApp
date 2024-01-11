namespace CashierApp.DataAccessor;

public interface IDataAccessor
{
    List<string[]> Read(string filePath);
}