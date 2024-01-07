using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Wrappers;

internal class DateTimeWrapper : IDateTime
{
    public DateTime Now()
    {
        return DateTime.Now;
    }
}
