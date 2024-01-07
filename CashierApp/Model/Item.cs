using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Model;

public class Item
{
    public int Id { get; init; }
    public string Name { get; init; }
    public decimal Price { get; init; }

    public Item(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Id} {Name} {Price}";
    }
}
