namespace CashierApp.CsvDataAccessor;

public interface IDataAccessor
{
    List<string[]> Read(string filePath);
}