using CashierApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Data;

internal class ItemsRepository : IRepository
{
    private IDataAccessor _accessor;
    public ItemsRepository(IDataAccessor accessor)
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
