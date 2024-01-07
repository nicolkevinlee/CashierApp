using CashierApp.Model;

namespace CashierApp.Data;

public interface IRepository
{
    List<Item> GetItemList();

}