namespace CashierApp.Data;

public interface IDataAccessor
{
    List<string[]> Read(string filePath);
}