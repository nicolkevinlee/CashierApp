using CashierApp.DTO;

namespace CashierApp.DataAccessor;

internal interface IDatabaseAccessor
{
    List<ItemsResult> Read();
}