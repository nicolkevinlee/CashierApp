using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Data;

internal class CSVFileAccessor : IDataAccessor
{
    public List<string[]> Read(string filePath)
    {

        var csvData = new List<string[]>();
        using (TextFieldParser parser = new TextFieldParser(filePath)) 
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while(!parser.EndOfData)
            {
                string[]? fields = parser.ReadFields();
                if(fields is not null) csvData.Add(fields);
            }
        }
        return csvData;
    }
}
