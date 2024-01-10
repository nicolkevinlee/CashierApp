using CashierApp.Model;

namespace CashierApp.Data;

public interface IApiRepository
{
    Task<List<Item>> GetItemList();
}