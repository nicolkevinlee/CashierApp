using CashierApp.Model;

namespace CashierApp.Data;

public interface IRepository
{
    Task<List<Item>> GetItemList();

}