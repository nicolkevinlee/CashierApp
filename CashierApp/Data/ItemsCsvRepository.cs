using CashierApp.CsvDataAccessor;
using CashierApp.Model;

namespace CashierApp.Data;

internal class ItemsCsvRepository : IRepository
{
    private IDataAccessor _accessor;
    public ItemsCsvRepository(IDataAccessor accessor)
    {
        _accessor = accessor;
    }

    public List<Item> GetItemList()
    {
        var fileContents = _accessor.Read("PriceList.csv");

        var itemList = new List<Item>();

        foreach (var rawItemFields in fileContents)
        {
            var id = int.Parse(rawItemFields[0]);
            var itemName = rawItemFields[1];
            var price = decimal.Parse(rawItemFields[2]);
            itemList.Add(new Item(
                id,
                itemName,
                price));
        }

        return itemList;
    }

}
