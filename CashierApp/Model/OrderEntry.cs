using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Model;

public class OrderEntry
{
    private Item _orderItem { get; init; }
    public int Count { get; init; }

    public string Name
    {
        get
        {
            return _orderItem.Name;
        }
    }

    public decimal Amount
    {
        get
        {
            return _orderItem.Price * Count;
        }
    }

    public OrderEntry(Item item, int count)
    {
        _orderItem = item;
        Count = count;
    }

    public override string ToString()
    {
        return $"{Count} {Name}";
    }

}