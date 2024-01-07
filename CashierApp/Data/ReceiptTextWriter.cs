using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Data;

internal class ReceiptTextWriter : IWriter
{
    private string _fileDirectory = "Receipts";
    public void Write(string text)
    {
        if(!Directory.Exists(_fileDirectory)) 
        {
            Directory.CreateDirectory(_fileDirectory);
        }

        var currentTime = DateTime.Now;

        var fileName = $"Receipt_{currentTime.ToString("yyyyMMddHHmmssfff")}.txt";

        File.WriteAllText(Path.Combine(_fileDirectory, fileName), text);
    }
}
